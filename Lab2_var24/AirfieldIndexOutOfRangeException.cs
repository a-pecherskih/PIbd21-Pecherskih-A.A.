using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_var24
{
    class AirfieldIndexOutOfRangeException : Exception
    {
        public AirfieldIndexOutOfRangeException() :
            base("В аэродроме нет самолетов по такому месту")
        { }
    }
}
