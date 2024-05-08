using SaveOceanII.DTOs.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheOceanII.DTOs.AnimalsFiles
{
    public class RescueFileDto
    {
        private static Random Random = new Random();
        private readonly string Prefix = "Res-";
        private readonly int MinId=0, MaxId=1000, MinGA= 0, MaxGA=100;
        public int Id {  get; set; }
        public string RescueId { get; set; }
        public DateTime RescueDate { get; set; }= DateTime.Now;
        public int GA {  get; set; }
        public string Family { get; set; }
        public string Location {  get; set; }
       public RescueFileDto() { }
       public RescueFileDto(string family,string location)
        {
            RescueId = Prefix+Random.Next(MinId,MaxId);
            GA = Random.Next(MinGA, MaxGA);
            Family = family;
            Location = location;
        }
    }
}
