using Npgsql;
using SaveOceanII.DTOs.Employee;
using SaveOceanII.Persistence.Utils;
using SaveOceanII.DTOs.Animals;

namespace SaveOceanII.Persistence.Mapping
{
    public class FamilyDao
    {
        private readonly string connectionString;

        public FamilyDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<FamilyDto> GetJobs()
        {
            List<FamilyDto>families = new List<FamilyDto>();
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "select name from family";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    families.Add(NpgsqlUtils.GetFamily(reader));
                }
            }
            return families;
        }
    }
}
