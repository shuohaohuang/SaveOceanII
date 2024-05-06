using SaveOceanII.DTOs.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveOceanII.Persistence.DAO
{
    public interface ISeaBird
    {
        public IEnumerable<SeaBirdDto> GetSeaBirds();
        void AddSeaBird(SeaBirdDto seaBird);
        void UpdateSeaBird(SeaBirdDto seaBird);
        void DeleteSeaBird(int id);
    }
}
