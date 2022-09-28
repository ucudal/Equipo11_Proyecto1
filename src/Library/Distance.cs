using System;
using System.Collections;
using System.Collections.Generic;
using ClassLibrary;

namespace ClassLibrary
{
    /// <summary>
    /// Clase Distance
    /// Conoce el metodo DistanceCalculator 
    /// </summary>
    public class Distance
    {
        /// <summary>
        /// Calcula la distancia entre trabajador y empleado para ver si cumple el radio de distancia ingresado por el trabajador
        /// </summary>
        /// <param name="person1"></param>
        /// <param name="person2"></param>
        /// <returns></returns>
        public static int DistanceCalculator(IPerson person1, IPerson person2)
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
