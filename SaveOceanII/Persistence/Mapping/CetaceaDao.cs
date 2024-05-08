using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using SaveOceanII.DTOs.Animals;
using SaveOceanII.DTOs.Employee;
using SaveOceanII.Persistence.DAO;
using SaveOceanII.Persistence.Utils;

namespace SaveOceanII.Persistence.Mapping
{
    public class CetaceaDao : ICetacea
    {
        private readonly string connectionString;

        public CetaceaDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddCetacea(CetaceaDto cetacea)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query =
                    "insert into animal(family, name)"
                    + "VALUES(@family,@name)";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);

                command.Parameters.AddWithValue("family", cetacea.Family);
                command.Parameters.AddWithValue("name", cetacea.Species);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteCetacea(string name)
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

        public IEnumerable<CetaceaDto> GetCetaceas()
        {
            List<CetaceaDto> cetaceas = new List<CetaceaDto>();

            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "select name,family from animal where family = 'Cetaci'";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cetaceas.Add(NpgsqlUtils.GetCetacea(reader));
                }
            }
            return cetaceas;
        }

        public void UpdateCetacea(CetaceaDto cetacea)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query =
                    "update animal set name=@name, where name=@specie";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("name", cetacea.Species);
                command.Parameters.AddWithValue("specie", cetacea.Species);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
