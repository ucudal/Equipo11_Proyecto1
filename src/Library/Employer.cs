using System.Collections.Generic;
using Locate;

namespace ClassLibrary
{
    public class Employer : IPerson
    {
        private string name;
        private string phoneNumber;
        private string emailAddress;
        private string id;
        public Location Location {get; set;}
        public int MaxDistance { get; set; }
        private Service service;

        public double StarsRating { get; set; }
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
        public Employer(string name, string phoneNumber, string emailAddress, string id, Location location, int maxDistance, Service service)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.EmailAddress = emailAddress;
            this.Id = id;
            this.Location = location;
            this.MaxDistance = maxDistance;
            this.Service = service;

        }
    }
}