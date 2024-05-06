using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaveOceanII.Interfaces;

namespace SaveOceanII.DTOs.Animals
{
    public class SeaBirdDto : AAnimal, IHealAble
    {
        private const string NameC = "PicoLargo";
        private const string FamilyC = "Au marina";
        private const string SpeciesC = "Gavina";
        private const float WeightC = 2.3f;

        public SeaBirdDto(string names, string family, string species, float weight) : base(names, family, species, weight)
        {
        }
        public SeaBirdDto() : this(NameC, FamilyC, SpeciesC, WeightC)
        {
        }

        public int Heal(int actualState, bool transfer)
        {
            int risc = transfer ? 5 : 0;
            return (int)(actualState - Math.Pow(actualState, 2) + risc);
        }
    }
}
