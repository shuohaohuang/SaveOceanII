// Ignore Spelling: DAO

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaveOceanII.DTOs.Employee;

namespace SaveOceanII.Persistence.DAO
{
    public interface IJob
    {
        public IEnumerable<JobDto> GetJobs();
    }
}
