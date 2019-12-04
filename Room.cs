using System;

namespace oopd_011
{
    class Room
    {
        public double temp;
        public double ambientTemp;

        public Room(double ambientTemp)
        {
            this.ambientTemp = ambientTemp;
            temp = 25;
        }

        public void UpdateTemp()
        {
            if (temp > ambientTemp)
            {
                temp -= 0.1;
            }
            else if (temp < ambientTemp)
            {
                temp += 0.1;
            }
            else
            {
                //temp -= 0.1;
            }
        }

        public void HeatRoom()
        {
            temp += 1;
        }

        public void CoolRoom()
        {
            temp -= 1;
        }

    }
}