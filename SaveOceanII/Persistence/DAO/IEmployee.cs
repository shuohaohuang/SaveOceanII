// Ignore Spelling: DAO

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaveOceanII.DTOs.Employee;

namespace SaveOceanII.Persistence.DAO
{
    public interface IEmployee
    {
        EmployeeDto GetEmployeeById(int id);
        EmployeeDto GetEmployeeByName(string name);

        public IEnumerable<EmployeeDto> GetEmployees();
        void AddEmployee(EmployeeDto employee);
        void UpdateEmployee(EmployeeDto employee);
        void DeleteEmployee(int id);
    }
}
