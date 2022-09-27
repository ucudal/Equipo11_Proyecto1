using System.Collections.Generic;

namespace ClassLibrary
{
    /// <summary>
    /// Conoce una lista de tipo workers
    /// </summary>
    public class ActiveWorkers
    {
        /// <summary>
        /// Conoce cada instancia de Worker creada
        /// </summary>
        /// <typeparam name="Worker"></typeparam>
        /// <returns></returns>
        public static List<Worker> activeWorkers {get;set;}
    }
}

