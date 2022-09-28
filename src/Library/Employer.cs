using System.Collections.Generic;

namespace ClassLibrary
{
    public class Employer : IPerson
    {
        /// <summary>
        /// Constructor de la clase Employer
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="emailAddress"></param>
        /// <param name="id"></param>
        /// <param name="location"></param>
        /// <param name="service"></param>
        public Employer(string name, string phoneNumber, string emailAddress, string id, double minimumRating, Location location, Service service)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.EmailAddress = emailAddress;
            this.Id = id;
            this.MinimumRating= minimumRating;
            this.Rating= 0;
            this.Reputation = new List<Rate>();
            this.Location = location;
            this.ServicesList= new List<Service> () {service};
        }
        private string name;
        private string phoneNumber;
        private string emailAddress;
        private string id;
        private double minimumRating;
        private double rating;


        /// <summary>
        /// Nombre del contratador
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
        /// Contacto telefonico del contratador
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
        /// Instancia de Location --> ubicación[x, y] del contratador --> permite calcular su distancia con el trabajador
        /// </summary>
        /// <value></value>
        public Location Location { get; set; }


        /// <summary>
        /// Mail de contacto del contratador
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
        /// Cedula de identidad del contratador --> otorga seguridad a quien trabaje para el en caso de que surgan problemas
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

        /// <summary>
        /// Valoracion minima bajo la cual contrata el employer
        /// </summary>
        /// <value></value>
        public double MinimumRating
        {
            get
            {
                return this.minimumRating;
            }
            set
            {
                if (value <= 5)
                {
                    this.minimumRating = value;
                }
            }
        }

        /// <summary>
        /// Lista con instancias de Rate --> provee puntuaciones y descripciones realizadas por usuarios que trabajaron para dicho contratador
        /// </summary>
        /// <value></value>
        public List<Rate> Reputation { get; set; }

        /// <summary>
        /// Lista con instancias de Service --> indica el trabajo que ofrece
        /// </summary>
        /// <value></value>
        public List<Service> ServicesList { get; set; }

        /// <summary>
        /// Puntuacion global del contratador
        /// </summary>
        /// <value></value>
        public double Rating
        {
            get
            {
                return this.rating;
            }
            set
            {
                if (value <= 5)
                {
                    this.rating = value;
                }
            }
        }

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