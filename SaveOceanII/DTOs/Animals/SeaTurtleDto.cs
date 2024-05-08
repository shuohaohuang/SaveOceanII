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
        private const string FamilyC = "Totuga marina";
        private const string SpeciesC = "Tortuga Careta";
        public new string Family { get; private set; } = FamilyC;

        public SeaTurtleDto(string family, string species)
            : base(family, species) { }

        public SeaTurtleDto()
            : this(FamilyC, SpeciesC) { }

        public int Heal(int actualState, bool transfer)
        {
            int risc = transfer ? 15 : 15;
            return (int)(2 * actualState + 3) - ((actualState - 20) * 2) - risc;
        }
    }
}
