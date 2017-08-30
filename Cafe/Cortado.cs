using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    public class Cortado : Kaffe , IMælk
    {
        /// <summary>
        /// Hvor meget mælk til en Cortado
        /// </summary>
        /// <returns></returns>
        public int MlMælk()
        {
            return 25;
        }

        /// <summary>
        /// Prisen på Cortado
        /// </summary>
        /// <returns></returns>
        public override int Pris()
        {
            return 25;
        }
    }
}
