using System.Collections.Generic;
using Locate;
namespace ClassLibrary
{
    /// <summary>
    /// Clase Worker
    /// Conoce datos personales del trabajador (Name, PhoneNumber, EmailAdress, Id).
    /// Conoce Salary
    /// Conoce ServicesList
    /// Conoce MaxDistance
    /// Cada vez que crea una instancia, la añade a la lista activeWorkers
    /// </summary>
    public class Worker : IPerson
    {
        public Worker(string name, string phoneNumber, string emailAddress, string id, int salary, int maxDistance, Location location, Service service)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.EmailAddress = emailAddress;
            this.Id = id;
            this.Salary = salary;
            this.MaxDistance = maxDistance;
            this.Location = location;
            this.Service = service;
            this.Rating= 0;
            this.Reputation = new List<Rate>();
            this.ServicesList.Add(this.Service);
            this.activeWorkers.Add(this);
        }
        private string name;
        private string phoneNumber;
        private string emailAddress;
        private string id;
        private Service service { get; set; }

        /// <summary>
        /// Nombre del trabajador
        /// </summary>
        /// <value></value>
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }

        /// <summary>
        /// Contacto telefonico del trabajador
        /// </summary>
        /// <value></value>
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 9)
                {
                    this.phoneNumber = value;
                }
            }
        }

        /// <summary>
        /// Instancia de Location --> ubicación[x, y] del trabajador --> permite calcular su distancia con el empleador
        /// </summary>
        /// <value></value>
        public Location Location { get; set; }

        /// <summary>
        /// Mail de contacto del trabajador
        /// </summary>
        /// <value></value>
        public string EmailAddress
        {
            get
            {
                return this.emailAddress;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Contains("@"))
                {
                    this.emailAddress = value;
                }
            }
        }

        /// <summary>
        /// Cedula de identidad del trabajador --> otorga seguridad a quien lo contrate en caso de que surgan problemas
        /// </summary>
        /// <value></value>
        public string Id
        {
            get
            {
                return this.id;
            }
            //El comentario refiere a la clase y metodo que usamos en un ejercicio viejo para validar cedulas, habria que preguntar is lo podemos "copiar".
            set
            {
                //if (IdUtils.IdIsValid(value))
                //{
                this.id = value;
                //}
            }
        }
        private double rating;

        /// <summary>
        /// Lista con instancias de Rate --> provee puntuaciones y descripciones realizadas por usuarios que contrataron a dicho trabajador
        /// </summary>
        /// <value></value>
        public List<Rate> Reputation { get; set; }

        /// <summary>
        /// Instancia de Service --> indica el trabajo que ofrece
        /// </summary>
        /// <value></value>
        public Service Service
        {
            get
            {
                return this.service;
            }
            set
            {
                if (this.service != null)
                {
                    this.service = value;
                }
            }
        }

        /// <summary>
        /// Indica el radio maximo de distancia que el trabajador esta dispuesto a "recorrer"
        /// </summary>
        /// <value></value>
        public int MaxDistance { get; set; }

        /// <summary>
        /// Lista de instancias Service --> el trabajador puede ofrecer mas de un unico servicio
        /// </summary>
        /// <value></value>
        public List<Service> ServicesList { get; set; }

        /// <summary>
        /// Lista que contiene instancias de Worker --> base de datos de todas las ofertas de trabajo activas disponibles 
        /// </summary>
        private List<Worker> activeWorkers;

        /// <summary>
        /// Pago minimo fijado por un trabajador para un determinado servicio
        /// </summary>
        /// <value></value>
        public int Salary { get; set; }

        /// <summary>
        /// Valor promedio de los ratings del trabajador
        /// </summary>
        /// <value></value>
        public double Rating {get;set;}

    }
}