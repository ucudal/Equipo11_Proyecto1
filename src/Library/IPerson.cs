using System.Collections.Generic;

namespace ClassLibrary
{

    /// <summary>
    /// Esta interfaz representa las operaciones relativas a los datos personales, ya sea del empleado o del empleador
    /// </summary>
    public interface IPerson
    {
        /// <summary>
        /// Getter del nombre de la persona
        /// </summary>
        /// <value></value>
        string Name { get; }

        /// <summary>
        /// Getter del numero telefonico de la persona
        /// </summary>
        /// <value></value>
        string PhoneNumber { get; }

        /// <summary>
        /// Getter de la direccion de mail de la persona
        /// </summary>
        /// <value></value>
        string EmailAddress { get; }

        /// <summary>
        /// Getter del id de la persona
        /// </summary>
        /// <value></value>
        string Id { get; }

        /// <summary>
        /// Valoracion promedio de los ratings de la persona
        /// </summary>
        /// <value></value>
        public double Rating {get;set;}

        /// <summary>
        /// Lista con instancias de evaluacion (cada instancia cuenta con una puntuacion y una descripcion)
        /// </summary>
        /// <value></value>
        List<Rate> Reputation {get; set;}

        /// <summary>
        /// Getter de la ubicacion de una persona (coordenadas)
        /// </summary>
        /// <value></value>
        Location Location { get; set;}

        /// <summary>
        /// Getter de la instancia servicio de una persona --> conoce el campo de trabajo, el trabajo mismo, su descripcion, y el precio esperado
        /// </summary>
        /// <value></value>
        List<Service> ServicesList { get; set; }

        /// <summary>
        /// Metodo que añade una instancia de service a Person.ServicesList
        /// </summary>
        /// <param name="service"></param>
        void AddService(Service service);

        
    }
}