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
    public class SeaBirdDao : ISeaBird
    {
        private readonly string connectionString;

        public SeaBirdDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddSeaBird(SeaBirdDto seaBird)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query =
          "insert into animal(family, name)"
          + "VALUES(@family,@name)";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);

                command.Parameters.AddWithValue("family", seaBird.Family);
                command.Parameters.AddWithValue("name", seaBird.Species);
            }
        }

        public void DeleteSeaBird(string name)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query =
                    "delete from animal where name=@name ";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("name", name);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<SeaBirdDto> GetSeaBirds()
        {
            List<SeaBirdDto> seaBirds = new List<SeaBirdDto>();

            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "select name,family from animal where family = 'Au marina'";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    seaBirds.Add(NpgsqlUtils.GetSeaBird(reader));
                }
            }
            return seaBirds;
        }

        public void UpdateSeaBird(SeaBirdDto seaBird)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query =
                    "update animal set name=@name, where name=@specie";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("name", seaBird.Species);
                command.Parameters.AddWithValue("specie", seaBird.Species);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
