using SaveOceanII.DTOs.Animals;
using SaveOceanII.DTOs.Employee;
using SaveTheOceanII.DTOs.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheOceanII.Persistence.DAO
{
    internal interface IAnimal
    {
        public IEnumerable<AnimalDto> GetAnimals();
        void AddAnimal(AnimalDto animalDto);
        void UpdateAnimal(AnimalDto animalDto);

    }
}
