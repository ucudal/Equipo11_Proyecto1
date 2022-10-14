//

using System.Collections.Generic;

namespace ClassLibrary
{
    /// <summary>
    /// Esta clase se encarga de realizar un filtro entre los servicios que ofrece el trabajador y el empleador
    /// y determinar si existe una coincidencia o no
    /// </summary>
    public class ServiceFilter
    {
        /// <summary>
        /// Metodo que devuelve un valor booleano respecto a si los service que busca un employer coinciden con los que ofrece un trabajador
        /// </summary>
        /// <param name="worker"></param>
        /// <param name="employer"></param>
        /// <returns></returns>
        public static bool FilterService(Worker worker, Employer employer)
        {
            bool output = false;
            List<Service> servicesMatchs = new List<Service>();
            foreach (Service workerService in worker.ServicesList)
            {
                foreach (Service employerService in employer.ServicesList)
                {
                    output = workerService.Job.SpecificJob == employerService.Job.SpecificJob;
                }
            }
            return output;
        }
    }
}


