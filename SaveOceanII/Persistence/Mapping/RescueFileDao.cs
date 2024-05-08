using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using SaveOceanII.DTOs.Animals;
using SaveOceanII.DTOs.Employee;
using SaveOceanII.Persistence.Utils;
using SaveTheOceanII.DTOs.AnimalsFiles;
using SaveTheOceanII.Persistence.DAO;

namespace SaveTheOceanII.Persistence.Mapping
{
    internal class RescueFileDao : IRescueFile
    {
        private readonly string connectionString;

        public RescueFileDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddRescueFile(RescueFileDto rescueFile)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query =
                    "insert into rescueFile(resid, date, ga, family, location) "
                    + "VALUES (@resid, @date, @ga, @family, @location)";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("resid", rescueFile.RescueId);
                command.Parameters.AddWithValue("date", rescueFile.RescueDate);
                command.Parameters.AddWithValue("ga", rescueFile.GA);
                command.Parameters.AddWithValue("family", rescueFile.Family);
                command.Parameters.AddWithValue("location", rescueFile.Location);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public RescueFileDto GetRescueFileById(int id)
        {
            RescueFileDto rescueFile = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query =
                    "select id,resid,date,ga,family,location " + "from rescueFile where id =@id";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    rescueFile = NpgsqlUtils.GetRescueFile(reader);
                }
            }

            return rescueFile;
        }

        public IEnumerable<RescueFileDto> GetRescueFile()
        {
            List<RescueFileDto> rescueFiles = new List<RescueFileDto>();
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "select id,resid,date,ga,family,location from rescueFile";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    rescueFiles.Add(NpgsqlUtils.GetRescueFile(reader));
                }
            }
            return rescueFiles;
        }
    }
}
