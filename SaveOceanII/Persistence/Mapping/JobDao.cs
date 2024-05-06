using Npgsql;
using SaveOceanII.DTOs.Employee;
using SaveOceanII.Persistence.DAO;
using SaveOceanII.Persistence.Utils;

namespace SaveOceanII.Persistence.Mapping
{
    public class JobDao : IJob
    {
        private readonly string connectionString;

        public JobDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<JobDto> GetJobs()
        {
            List<JobDto> jobs = new List<JobDto>();
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "select name from job";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    jobs.Add(NpgsqlUtils.GetJob(reader));
                }
            }
            return jobs;
        }

    }
}
