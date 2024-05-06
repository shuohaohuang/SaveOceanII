using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveOceanII.Interfaces
{
    public interface IHealAble
    {

        /// <summary>
        /// Retorna l'exit de la operació
        /// </summary>
        /// <param name="actualState">rep l'estat actual del animal </param>
        /// <param name="transfer">si s'ha mogut l'animal a un centre </param>
        /// <returns>Retorna un integer, eficacia de la cura</returns>
        abstract int Heal(int actualState, bool transfer);

    }
}
