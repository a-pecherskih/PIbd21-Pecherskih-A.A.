using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_var24_C
{
    class Oil
    {
        /// Масло в наличии. Есть/нет
        public bool State { set; get; }

        /// Степень готовности масла
        private int temperature = 0;

        /// Узнаем температуру масла
        public int Temperature { get { return temperature; } }

        /// Повышаем тем-ру масла, пока оно не закипит
        public void GetHeat()
        {
            if (temperature < 100)
            {
                temperature++;
            }
        }

        /// Если масло есть, то даем масло
        public Oil GetOil()
        {
            if (State)
            {
                return new Oil();
            }
            else
            {
                return null;
            }
        }
    }
}
