using System;

namespace ClassLibrary
{
    /// <summary>
    /// Clase Service
    /// Conoce la string Field (campo de trabajo)
    /// Conoce la string SpecificJob (nombre especifico del trabajo)
    /// Conoce la descripcion del trabajo
    /// Conoce el coste a pagar del trabajo
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Constructor de la clase Service
        /// </summary>
        /// <param name="field"></param>
        /// <param name="specificJob"></param>
        /// <param name="description"></param>
        /// <param name="cost"></param>
        public Service(Jobs job, string description, int cost)
        {
            this.Job= job;
            this.Description = description;
            this.Cost = cost;
        }
        private Jobs job;
        private string description;
        private double starsRating;

        /// <summary>
        /// Instancia de Jobs, cuyos atributos son el nombre del rubro y el nombre especifico del trabajo.
        /// </summary>
        /// <value></value>
        public Jobs Job {get; set;}

        /// <summary>
        /// Descripción formal del trabajo.
        /// </summary>
        /// <value></value>
        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.description = value;
                }
            }
        }

        /// <summary>
        /// Lo que la persona espera pagar(contratador)/cobrar(trabajador) por dicho servicio
        /// </summary>
        /// <value></value>
        public int Cost { get; set; }
    }
}