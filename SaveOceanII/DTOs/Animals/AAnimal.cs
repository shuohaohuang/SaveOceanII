using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveOceanII.DTOs.Animals
{
    public class AAnimal
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Species { get; set; }
        public float Weight { get; set; }

        public AAnimal(string names, string family, string species, float weight)
        {
            this.Name = names;
            this.Family = family;
            this.Species = species;
            this.Weight = weight;
        }
    }
}
