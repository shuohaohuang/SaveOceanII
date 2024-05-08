using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Npgsql;
using SaveOceanII.DTOs.Animals;
using SaveOceanII.Persistence.DAO;
using SaveOceanII.Persistence.Utils;

namespace SaveOceanII.Persistence.Mapping
{
    public class SeaTurtleDao : ISeaTurtle
    {
        private readonly string connectionString;

        public SeaTurtleDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddSeaTurtle(SeaTurtleDto seaTurtle)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "insert into animal(family, name)" + "VALUES(@family,@name)";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);

                command.Parameters.AddWithValue("family", seaTurtle.Family);
                command.Parameters.AddWithValue("name", seaTurtle.Species);
            }
        }

        public void DeleteSeaTurtle(string name)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "delete from animal where name=@name ";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("name", name);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public SeaTurtleDto GetSeaTurtleById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SeaTurtleDto> GetSeaTurtles()
        {
            List<SeaTurtleDto> seaTurtles = new List<SeaTurtleDto>();
            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "select name,family from animal where family = 'Tortuga marina'";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    seaTurtles.Add(NpgsqlUtils.GetSeaTurtle(reader));
                }
            }
            return seaTurtles;
        }

        public void UpdateSeaTurtle(SeaTurtleDto seaTurtle)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "update animal set name=@name, where name=@specie";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("name", seaTurtle.Species);
                command.Parameters.AddWithValue("specie", seaTurtle.Species);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
