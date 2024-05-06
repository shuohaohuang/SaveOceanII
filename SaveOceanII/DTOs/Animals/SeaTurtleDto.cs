using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaveOceanII.Interfaces;

namespace SaveOceanII.DTOs.Animals
{
    public class SeaTurtleDto : AAnimal, IHealAble
    {
        private const string NameC = "Aletas";
        private const string FamilyC = "Totuga marina";
        private const string SpeciesC = "Tortuga Careta";
        private const float WeightC = 2.3f;

        public SeaTurtleDto(string names, string family, string species, float weight)
            : base(names, family, species, weight) { }

        public SeaTurtleDto()
            : this(NameC, FamilyC, SpeciesC, WeightC) { }

        public int Heal(int actualState, bool transfer)
        {
            int risc = transfer ? 5 : 5;
            return actualState - ((actualState - 2) * (2 * actualState + 3)) - risc;
        }
        
    }
}
