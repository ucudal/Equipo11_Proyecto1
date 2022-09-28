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
        public Service(string field, string specificJob, string description, int cost)
        {
            this.Field = field;
            this.SpecificJob = specificJob;
            this.Description = description;
            this.Cost = cost;
        }
        private string fieldArea;
        private string field;
        private string description;
        private double starsRating;

        /// <summary>
        /// Campo de trabajo del servicio --> debe exister como clave dentro del diccionario JobFields.WorkFields 
        /// </summary>
        /// <value></value>
        public string Field
        {
            get
            {
                return this.field;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && JobFields.WorkFields.ContainsKey(value))
                {
                    this.field = value;
                }
            }
        }
        private string specificJob;

        /// <summary>
        /// Nombre mas especifico del trabajo --> debe existir como valor dentro del Field ingresado
        /// </summary>
        /// <value></value>
        public string SpecificJob
        {
            get
            {
                return this.specificJob;
            }
            set
            {
                //Aseguro que la string se encuentre dentro de la lista asociada a la clave Field
                if (!string.IsNullOrEmpty(value) && JobFields.WorkFields[this.field].Contains(value))
                {
                    this.specificJob = value;
                }
            }
        }

        /// <summary>
        /// Descripcion formal del trabajo
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