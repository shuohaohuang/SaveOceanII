// Ignore Spelling: Utils

using Microsoft.Extensions.Configuration;
using Npgsql;
using SaveOceanII.DTOs.Animals;
using SaveOceanII.DTOs.Employee;
using SaveTheOceanII.DTOs.Animals;
using SaveTheOceanII.DTOs.AnimalsFiles;

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
        public static CetaceaDto GetCetacea(NpgsqlDataReader reader)
        {
            CetaceaDto c = new CetaceaDto
            {
                Species = reader.GetString(0)

            };
            return c;
        }
        public static SeaBirdDto GetSeaBird(NpgsqlDataReader reader)
        {
            SeaBirdDto s = new SeaBirdDto
            {
                Species = reader.GetString(0)
            };
            return s;
        }
        public static SeaTurtleDto GetSeaTurtle(NpgsqlDataReader reader)
        {
            SeaTurtleDto s = new SeaTurtleDto
            {
                Species = reader.GetString(0)

            };
            return s;
        }
        public static AnimalDto GetAniml(NpgsqlDataReader reader)
        {
            AnimalDto a = new AnimalDto
            {
                Species = reader.GetString(0),
                Family = reader.GetString(1)
            };
            return a;
        }
        public static RescueFileDto GetRescueFile(NpgsqlDataReader reader)
        {
            RescueFileDto f = new RescueFileDto
            {
                Id = reader.GetInt32(0),
                RescueId = reader.GetString(1),
                RescueDate = reader.GetDateTime(2),
                GA = (int)reader.GetFloat(3) ,
                Family = reader.GetString(4),
                Location = reader.GetString(5),
            };
            return f;
        }
    }
}
