using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_var24_C
{
    class Knife
    {
        public void Clean(Potato p)
        {
            if (p.Have_skin)
            {
                p.Have_skin = false;
            }
        }

        /// Метод принимает картошку, если есть кожура - удаляет
        public void Slice(Potato p)
        {
            p.Have_parts = 10;
        }
    }
}
