using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_var24_C
{
    class WaterTap
    {
        /// Состояние крана. Открыт/закрыт
        public bool State { set; get; }

        /// Если кран открыт, то картошка будет вымыта
        public void Wash(Potato p)
        {
            if (State)
            {
                p.Dirty = 0;
            }
        }
    }
}
