using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_var24
{
    class AirfieldAlreadyHaveException : Exception
    {
        public AirfieldAlreadyHaveException() :
            base("Такой самолет уже есть")
        { }
    }
}
