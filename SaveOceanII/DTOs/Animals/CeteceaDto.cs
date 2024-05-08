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

        private const string FamilyC = "Cetaci";
        private const string SpeciesC = "delfí";
        public new string  Family { get; private set; } = FamilyC;

        public CetaceaDto( string family, string species) : base(family, species)
        {
        }
        public CetaceaDto() : this( FamilyC, SpeciesC)
        {
        }
        public int Heal(int actualState, bool transfer)
        {
            int risc = transfer ? 0 : 50;
            return (int)(actualState - actualState/5 - risc);
        }
    }
}
