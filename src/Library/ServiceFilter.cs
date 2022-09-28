using System.Collections.Generic;

namespace ClassLibrary
{
    /// <summary>
    /// Esta clase se encarga de realizar un filtro entre los servicios que ofrece el trabajador y el empleador
    /// y determinar si existe una coincidencia o no
    /// </summary>
    public class ServiceFilter
    {
        public static bool serviceFilter(Worker worker, Employer employer)
        {
            List<Service> servicesMatchs = new List<Service>();
            bool output=true;
            foreach(Service workerService in worker.ServicesList)
            {
                foreach(Service employerService in employer.ServicesList)
                {
                    if(workerService.SpecificJob==employerService.SpecificJob)
                    {
                        output=true;
                    }
                    else
                    {
                        output=false;
                    }
                }
            }
            return output;
        }
    }
}

