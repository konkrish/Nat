using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopsLive.Models
{
    public class InterfaceClass : Interface
    {
        int speed;
        int gear;

        public void changeGear(int newGear)
        {
            gear = newGear;
        }

        public void speedUp(int increment)
        {
            speed = speed + increment;
        }

        public void applyBrakes(int decrement)
        {
            speed = speed - decrement;
        }

        public void printStates()
        {
            Console.WriteLine("speed: " + speed +
                              " gear: " + gear);
        }
    }
}