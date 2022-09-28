using System.Collections.Generic;

namespace ClassLibrary
{

    ///  Esta clase comparara los datos entre worker y empleador
    /// A partir de ahi dictaminara si existe un emparejamiento posible o no
    /// A futuro pensamos hacer uso del chatbot para darle la libertad de negociacion y flexibilizar algunos datos (ej: salario, ubicacion)
    /// Y que eso permita un emparejamiento a pesar de que los datos iniciales no coincidieran del todo
    public class Match
    {
        private IPerson person;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="employer"></param>
        /// <returns></returns>
        public static List<Worker> LookingForMatch(Employer employer)
        {
            List<Worker> matchList= new List<Worker> ();
            foreach (Worker worker in ActiveWorkers.activeWorkers)
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

                    }
                }

            }
            return matchList;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="worker"></param>
        /// <param name="employer"></param>
        /// <returns></returns>
        /// 
        private static bool ExactMatch(Worker worker, Employer employer)
        {
            if(ServiceFilter.serviceFilter(worker,employer)==true)
            {
                if (Rate.TotalRating(worker) >= employer.MinimumRating)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
            /// Aca se implementaria un chatbot de negociacion entre ambos, donde se pone en la mesa
            /// Que se debe modificar para poder emparejar, si lo desean modificar (y en caso afirmativo cómo)

            return true;
        }
    }
}