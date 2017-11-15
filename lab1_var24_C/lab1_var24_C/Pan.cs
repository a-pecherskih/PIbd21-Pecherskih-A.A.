using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_var24_C
{
    class Pan
    {
        private Oil[] oil;

        private Potato[] potatos;

        /// Состояние готовности
        public bool ReadyToGo
        {
            get
            {
                if (CheckOil() && CheckPotato())
                {
                    return true;
                }
                else return false;
            }
        }

        public void Init(int countPotatos)
        {
            potatos = new Potato[countPotatos];
        }

        public void InitOil()
        {
            oil = new Oil[3];
        }

        /// <summary>
        /// Добавляем масло в кастрюлю
        /// </summary>
        /// <param name="o"></param>
        public void AddOil(Oil o)
        {
            for (int i = 0; i < oil.Length; ++i)
            {
                if (oil[i] == null)
                {
                    oil[i] = o;
                    return;
                }
            }
        }

        public void AddPotato(Potato p)
        {
            for (int i = 0; i < potatos.Length; ++i)
            {
                if (potatos[i] == null)
                {
                    potatos[i] = p;
                    return;
                }
            }
        }

        /// Проверка. Все ли ингредиенты есть для готовки
        private bool CheckOil()
        {

            if (oil.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < oil.Length; ++i)
            {
                if (oil[i] == null)
                {
                    return false;
                }
            }


            return true;
        }

        private bool CheckPotato()
        {
            if (potatos.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < potatos.Length; ++i)
            {
                if (potatos[i] == null)
                {
                    return false;
                }
            }
            return true;
        }

        int flag = 0;
        /// готовка. Изменяем состояние масла
        public void GetHeat()
        {
            if (!CheckOil())
            {
                return;
            }
            if (oil.Length > 0)
            {
                while (oil[0].Temperature < 100)
                {
                    for (int i = 0; i < oil.Length; ++i)
                    {
                        oil[i].GetHeat();
                    }
                }
                if (flag == 1)
                {
                    for (int i = 0; i < potatos.Length; ++i)
                    {
                        potatos[i].GetHeat();
                    }
                }
                flag++;
            }
        }

        /// Проверяем готова ли картошка
        public bool IsReady()
        {
            for (int i = 0; i < oil.Length; ++i)
            {
                if (oil[i].Temperature < 100)
                {
                    return false;
                }
            }
            for (int i = 0; i < potatos.Length; ++i)
            {
                if (potatos[i].Has_ready < 10)
                {
                    return false;
                }
            }

            return true;
        }

        public Potato[] GetPotatos()
        {
            return potatos;
        }
    }
}
