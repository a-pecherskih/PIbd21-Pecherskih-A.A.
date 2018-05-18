using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_var24
{
    class AirfieldOverflowException : Exception
    {
        public AirfieldOverflowException() :
            base("В аэродроме нет свободных мест")
        { }
    }
}
