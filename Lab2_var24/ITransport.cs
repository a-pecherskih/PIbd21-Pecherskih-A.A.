using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_var24
{
    interface ITransport
    {
        void movePlane(Graphics g);

        void drawPlane(Graphics g);

        void setPosition(int x, int y);

        void loadPassenger(int count);

        int getPassenger();
    }
}
