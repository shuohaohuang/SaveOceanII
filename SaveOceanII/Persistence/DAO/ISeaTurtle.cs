using SaveOceanII.DTOs.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveOceanII.Persistence.DAO
{
    internal interface ISeaTurtle
    {
        public IEnumerable<SeaTurtleDto> GetSeaTurtles();
        void AddSeaTurtle(SeaTurtleDto seaTurtle);
        void UpdateSeaTurtle(SeaTurtleDto seaTurtle);
        void DeleteSeaTurtle(string name);
    }
}
