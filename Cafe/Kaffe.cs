using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    public abstract class Kaffe
    {
        public abstract int Pris();
        public virtual string Styrke()
        {
            return "stærk";
        }
    }
}
