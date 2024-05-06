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
        public int Id {  get; set; }
        public string RescueId { get; set; }
        public DateTime RescueDate { get; set; }= DateTime.Now;
        public string Family { get; set; }
        public string Location {  get; set; }

    }
}
