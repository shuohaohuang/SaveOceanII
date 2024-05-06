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
                    "insert into seabird(name, family, specie, weight)"
                    + "VALUES(@name,@family,@specie,@weight)";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("name", seaBird.Name);
                command.Parameters.AddWithValue("family", seaBird.Family);
                command.Parameters.AddWithValue("specie", seaBird.Species);
                command.Parameters.AddWithValue("weight", seaBird.Weight);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteSeaBird(int id)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "delete from seabird where id=@id";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<SeaBirdDto> GetSeaBirds()
        {
            List<SeaBirdDto> seaBirds = new List<SeaBirdDto>();

            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "select id,name,specie,weight from seabird";
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
                    "update seabird set name=@name,specie=@specie,weight=@weight where id=@id";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("id", seaBird.Id);
                command.Parameters.AddWithValue("name", seaBird.Name);
                command.Parameters.AddWithValue("specie", seaBird.Species);
                command.Parameters.AddWithValue("weight", seaBird.Weight);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
