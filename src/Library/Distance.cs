using System;
using System.Collections;
using System.Collections.Generic;
using Locate;
using ClassLibrary;
namespace ClassLibrary
{
    /// <summary>
    /// Esta clase calculara la distancia entre trabajador y empleado para ver si cumple el radio de distancia ingresado por el empleador
    /// </summary>
    public class Distance
    {
        public static int distanceCalculator(IPerson person1, IPerson person2)
        {
            double Distance = Math.Sqrt( (Math.Pow(person1.Location.getX(),2) + Math.Pow(person2.Location.getX(),2)) - ( Math.Pow(person1.Location.getY(),2) ) + ( Math.Pow(person2.Location.getY(),2)) );
            if(Distance<0)
            {
                return Convert.ToInt32(Distance)*-1;
            }
            else
            {
                return Convert.ToInt32(Distance);
            }

        }
    }
}
