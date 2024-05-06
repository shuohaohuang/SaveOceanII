// Ignore Spelling: Dao

using Npgsql;
using SaveOceanII.DTOs.Employee;
using SaveOceanII.Persistence.DAO;
using SaveOceanII.Persistence.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveOceanII.Persistence.Mapping
{
    public class EmployeeDao : IEmployee
    {
        private readonly string connectionString;

        public EmployeeDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddEmployee(EmployeeDto employee)
        {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    string query = "insert into employee (name, job, exp) values (@name,@job,@exp)";
                    NpgsqlCommand command = new NpgsqlCommand(query, connection);
                    command.Parameters.AddWithValue("name", employee.Name);
                    command.Parameters.AddWithValue("job", employee.Job);
                    command.Parameters.AddWithValue("exp", employee.Exp);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
           
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public EmployeeDto GetEmployeeById(int id)
        {
            EmployeeDto employee = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "select id,name,job,exp from employee where id=@id";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    employee = NpgsqlUtils.GetEmployee(reader);
                }
            }

            return employee;

        }

        public EmployeeDto GetEmployeeByName(string name)
        {
            List<EmployeeDto> employees = new List<EmployeeDto>();

            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "select id,name,job,exp from employee where name=@name";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);

                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    employees.Add(NpgsqlUtils.GetEmployee(reader));
                }
            }
            return employees.Last();
        }

        public void UpdateEmployee(EmployeeDto employee)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "update employee set name=@name, job = @job, exp=@exp where id = @id;";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("name", employee.Name);
                command.Parameters.AddWithValue("job", employee.Job);
                command.Parameters.AddWithValue("exp", employee.Exp);

                connection.Open();
                command.ExecuteNonQuery();
            }

        }
    }
}
