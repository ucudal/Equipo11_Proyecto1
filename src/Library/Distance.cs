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
        public static double DistanceCalculator(IPerson person1, IPerson person2)
        {
            double Distance = Math.Sqrt( (Math.Pow(person1.Location.getLatitude()-person2.Location.getLatitude(),2) ) + ( Math.Pow(person1.Location.getLongitude()-person2.Location.getLongitude(),2) ));
            return Distance;
        }
    }
}
