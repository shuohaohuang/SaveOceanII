﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveOceanII.DTOs.Animals
{
    public class AAnimal
    {
        public string Family { get; set; }
        public string Species { get; set; }

        public AAnimal( string family, string species)
        {

            this.Family = family;
            this.Species = species;

        }
    }
}
