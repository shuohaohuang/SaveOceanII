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
        private const string FamilyC = "Au marina";
        private const string SpeciesC = "Gavina";

        public new string Family { get; private set; } = FamilyC;

        public SeaBirdDto(string family, string species)
            : base(family, species) { }

        public SeaBirdDto()
            : this(FamilyC, SpeciesC) { }

        public int Heal(int actualState, bool transfer)
        {
            int risc = transfer ? 0 : 5;
            return (int)(actualState - risc)/5;
        }
    }
}
