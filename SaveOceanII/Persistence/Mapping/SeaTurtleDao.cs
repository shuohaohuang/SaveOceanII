using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                string query =
                    "insert into SeaTurtle(name, family, specie, weight)"
                    + "VALUES(@name,@family,@specie,@weight)";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("name", seaTurtle.Name);
                command.Parameters.AddWithValue("family", seaTurtle.Family);
                command.Parameters.AddWithValue("specie", seaTurtle.Species);
                command.Parameters.AddWithValue("weight", seaTurtle.Weight);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteSeaTurtle(int id)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "delete from SeaTurtle where id=@id";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);

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
                string query = "select id,name,specie,weight from SeaTurtle";
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
                string query =
                    "update SeaTurtle set name=@name,specie=@specie,weight=@weight where id=@id";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("id", seaTurtle.Id);
                command.Parameters.AddWithValue("name", seaTurtle.Name);
                command.Parameters.AddWithValue("specie", seaTurtle.Species);
                command.Parameters.AddWithValue("weight", seaTurtle.Weight);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
