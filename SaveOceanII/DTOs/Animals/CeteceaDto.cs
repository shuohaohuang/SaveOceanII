// Ignore Spelling: Cetacea

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaveOceanII.Interfaces;

namespace SaveOceanII.DTOs.Animals
{
    public class CetaceaDto : AAnimal, IHealAble
    {
        private const string NameC = "Espiraculo";
        private const string FamilyC = "Cetaci";
        private const string SpeciesC = "delfí";
        private const float WeightC = 302f;
        public new string  Family { get; private set; } = "Cetaci";

        public CetaceaDto(string names, string family, string species, float weight) : base(names, family, species, weight)
        {
        }
        public CetaceaDto() : this(NameC, FamilyC, SpeciesC, WeightC)
        {
        }
        public int Heal(int actualState, bool transfer)
        {
            int risc = transfer ? 25 : 0;
            return (int)(actualState - Math.Log10(actualState) - risc);
        }
    }
}
