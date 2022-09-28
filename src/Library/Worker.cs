using System.Collections.Generic;

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
        /// <summary>
        /// Constructor de la clase Worker
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="emailAddress"></param>
        /// <param name="id"></param>
        /// <param name="salary"></param>
        /// <param name="maxDistance"></param>
        /// <param name="location"></param>
        /// <param name="service"></param>
        public Worker(string name, string phoneNumber, string emailAddress, string id, int maxDistance, Location location, Service service)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.EmailAddress = emailAddress;
            this.Id = id;
            this.MaxDistance = maxDistance;
            this.Location = location;
            this.Rating= 0;
            this.Reputation = new List<Rate>();
            this.ServicesList= new List<Service>() {service};
            ActiveWorkers.activeWorkers.Add(this);
        }
        private string name;
        private string phoneNumber;
        private string emailAddress;
        private string id;

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
        /// Valor promedio de los ratings del trabajador
        /// </summary>
        /// <value></value>
        public double Rating {get;set;}

        /// <summary>
        /// Metodo que añade una instancia de service a Person.ServicesList
        /// </summary>
        /// <param name="service"></param>
        public void AddService(Service service)
        {
            if (service != null)
            {
                this.ServicesList.Add(service);
            }
        }
    }   
}