using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_var24_C
{
    class Potato
    {
        /// Состояние готовности
        private int has_ready = 0;

        private bool have_skin = true;

        private int dirty = 10;

        /// на сколько частей нарезана
        private int have_parts = 0;

        /// Наличие кожуры
        public bool Have_skin { set { this.have_skin = value; } get { return have_skin; } }

        /// проверка на сколько частей нарезана
        public int Have_parts
        {
            set { if (value > -1 && value < 11) have_parts = value; }
            get { return have_parts; }
        }

        /// Cостояние готовности
        public int Has_ready { get { return has_ready; } }

        /// Задаем состояние загрязненности
        public int Dirty
        {
            set { if (value > -1 && value < 11) dirty = value; }
            get { return dirty; }
        }

        /// Изменяем состояние готовности
        public void GetHeat()
        {
            if (has_ready < 10)
            {
                has_ready += 10;
            }
        }
    }
}
