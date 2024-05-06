// Ignore Spelling: DAO

using SaveOceanII.DTOs.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveOceanII.Persistence.DAO
{
    public interface Ifamily
    {
        public IEnumerable<JobDto> GetJobs();

    }
}
