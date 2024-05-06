// Ignore Spelling: Utils

using Microsoft.Extensions.Configuration;
using Npgsql;
using SaveOceanII.DTOs.Animals;
using SaveOceanII.DTOs.Employee;

namespace SaveOceanII.Persistence.Utils
{
    internal class NpgsqlUtils
    {
        public static string OpenConnection()
        {
            // Carregar la cadena de connexió a la base de dades des de l'arxiu de configuració
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(@"appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            return config.GetConnectionString("MyPostgresConn")??"";
        }

       public static EmployeeDto GetEmployee(NpgsqlDataReader reader)
       {
            EmployeeDto e = new EmployeeDto
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Job = reader.GetString(2),
                Exp = reader.GetInt32(3),
            };
           return e;
       }
        public static JobDto GetJob(NpgsqlDataReader reader)
        {
            JobDto j = new JobDto
            {
                Name = reader.GetString(0)
            };
            return j;
        }
        public static FamilyDto GetFamily(NpgsqlDataReader reader)
        {
            FamilyDto f = new FamilyDto
            {
                Name = reader.GetString(0)
            };
            return f;
        }
        public static CetaceaDto GetCetacea(NpgsqlDataReader reader)
        {
            CetaceaDto c = new CetaceaDto
            {
                Id=reader.GetInt32(0),
                Name = reader.GetString(1),
                Species=reader.GetString(2),
                Weight= reader.GetFloat(3)
            };
            return c;
        }
        public static SeaBirdDto GetSeaBird(NpgsqlDataReader reader)
        {
            SeaBirdDto s = new SeaBirdDto
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Species = reader.GetString(2),
                Weight = reader.GetFloat(3)
            };
            return s;
        }
        public static SeaTurtleDto GetSeaTurtle(NpgsqlDataReader reader)
        {
            SeaTurtleDto s = new SeaTurtleDto
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Species = reader.GetString(2),
                Weight = reader.GetFloat(3)
            };
            return s;
        }
    }
}
