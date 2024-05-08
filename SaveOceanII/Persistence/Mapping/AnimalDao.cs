using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using SaveOceanII.DTOs.Animals;
using SaveOceanII.Persistence.Utils;
using SaveTheOceanII.DTOs.Animals;
using SaveTheOceanII.Persistence.DAO;

namespace SaveTheOceanII.Persistence.Mapping
{
    public class AnimalDao : IAnimal
    {
        private readonly string connectionString;

        public AnimalDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<AnimalDto> GetAnimals()
        {
            List<AnimalDto> animals = new List<AnimalDto>();
            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "select name,family from animal";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    animals.Add(NpgsqlUtils.GetAniml(reader));
                }
            }
            return animals;
        }

        public void AddAnimal(AnimalDto animal)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "insert into animal(family, name) VALUES(@family,@name)";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);

                command.Parameters.AddWithValue("family", animal.Family);
                command.Parameters.AddWithValue("name", animal.Species);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdateAnimal(AnimalDto animal)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "update animal set name=@name,family=@family where name=@id";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("name", animal.Species);
                command.Parameters.AddWithValue("family", animal.Family);
                command.Parameters.AddWithValue("id", animal.Species);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
