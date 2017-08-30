using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    public class SortKaffe : Kaffe
    {
        public override int Pris()
        {
            int prismedrabat = 20 - Rabat;

            if (prismedrabat <= 0)
            {
                throw new ArgumentException("Uppss du gav for meget rabat");
            }

            return prismedrabat;

        }

        public SortKaffe()
        {

        }

        public SortKaffe(int rabat)
            :base(rabat)
        {

        }
    }
}
