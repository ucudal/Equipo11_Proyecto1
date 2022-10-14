// Juan Magrini

using System;

namespace ClassLibrary
{
    /// <summary>
    /// Clase Distance
    /// Conoce el metodo DistanceCalculator 
    /// </summary>
    public class DistanceCalculator
    {
        /// <summary>
        /// Calcula la distancia entre trabajador y empleado para ver si cumple el radio de distancia ingresado por el trabajador
        /// </summary>
        /// <param name="person1"></param>
        /// <param name="person2"></param>
        /// <returns></returns>
        public static double CalculateDistance(IPerson person1, IPerson person2)
        {
            double Distance = Math.Sqrt((Math.Pow(person1.Location.Latitude - person2.Location.Latitude, 2)) + (Math.Pow(person1.Location.Longitude - person2.Location.Longitude, 2)));
            return Distance;
        }
    }
}

/*  
Se crea una nueva clase para respetar el principio SRP.
Esta clase tiene como única responsabilidad calcular la distancia entre un usuario Employer y un usuario Worker; 
mediante el método CalculateDistance(IPerson person1, IPerson person2)
*/
