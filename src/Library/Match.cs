using System.Collections.Generic;

namespace ClassLibrary
{

    /// <summary>
    /// Esta clase comparara los datos entre worker y empleador.
    /// A partir de ahi dictaminara si existe un emparejamiento posible o no.
    /// A futuro pensamos hacer uso del chatbot para darle la libertad de negociacion y flexibilizar algunos datos (ej: salario, ubicacion).
    /// Y que eso permita un emparejamiento a pesar de que los datos iniciales no coincidieran del todo.
    /// </summary>
    public class Match
    {
        private IPerson person;

        /// <summary>
        /// Este metodo se encarga de retornar una lista (de la base de datos de trabajadores)
        /// con los trabajadores que coinciden con los servicios que el empleador tiene
        /// </summary>
        /// <param name="employer"></param>
        /// <returns></returns>
        public static List<Worker> LookingForMatch(Employer employer)
        {
            List<Worker> matchList= new List<Worker> ();
            foreach (Worker worker in ActiveWorkers.ActualWorkers)
            {
                if (ExactMatch(worker, employer))
                {
                    ConsolePrinter.MatchPrinter(worker, employer);
                    matchList.Add(worker);
                }
                else
                {
                    if (Negotiate(worker, employer))
                    {
                        // Funcion que abra chatbot
                    }
                }

            }
            return matchList;
        }

        /// <summary>
        /// Este metodo se encarga de determinar si existe un match exacto entre un empleado y un empleador segun sus preferencias personales
        /// </summary>
        /// <param name="worker"></param>
        /// <param name="employer"></param>
        /// <returns></returns>        
        private static bool ExactMatch(Worker worker, Employer employer)
        {
            if((ServiceFilter.FilterService(worker,employer)) & ( Rate.TotalRating(worker) >= employer.MinimumRating) & (DistanceCalculator.CalculateDistance(worker,employer)<=worker.MaxDistance ))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Metodo que habilita una negociacion de terminos (pago/distancia/valoracion minima) entre ambas partes
        /// </summary>
        /// <returns></returns>
        public static bool Negotiate(Worker worker, Employer employer)
        {
            // Aca se implementaria un chatbot de negociacion entre ambos, donde se pone en la mesa
            // Que se debe modificar para poder emparejar, si lo desean modificar (y en caso afirmativo cómo)

            return true;
        }
    }
}