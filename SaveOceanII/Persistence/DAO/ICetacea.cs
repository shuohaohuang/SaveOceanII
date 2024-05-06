using SaveOceanII.DTOs.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveOceanII.Persistence.DAO
{
    internal interface ICetacea
    {
        public IEnumerable<CetaceaDto> GetCetaceas();
        void AddCetacea(CetaceaDto cetacea);
        void UpdateCetacea(CetaceaDto cetacea);
        void DeleteCetacea(int id);
    }
}
