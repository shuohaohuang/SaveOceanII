using SaveOceanII.DTOs.Employee;
using SaveTheOceanII.DTOs.AnimalsFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheOceanII.Persistence.DAO
{
    internal interface IRescuefile
    {
        public IEnumerable<RescueFileDto> GetEmployees();
        void AddEmployee(RescueFileDto rescueFile);

    }
}
