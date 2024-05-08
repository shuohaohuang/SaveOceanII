using SaveOceanII.DTOs.Employee;
using SaveTheOceanII.DTOs.AnimalsFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheOceanII.Persistence.DAO
{
    internal interface IRescueFile
    {
        public IEnumerable<RescueFileDto> GetRescueFile();
        void AddRescueFile(RescueFileDto rescueFile);
        RescueFileDto GetRescueFileById(int id);


    }
}
