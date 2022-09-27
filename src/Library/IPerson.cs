using System.Collections.Generic;
using Locate;

namespace ClassLibrary
{

    /// <summary>
    /// Esta interfaz representa las operaciones relativas a los datos personales, ya sea del empleado o del empleador
    /// </summary>
    public interface IPerson
    {
        //  Getter del nombre de la persona
        string Name { get; }

        //  Getter del numero telefonico de la persona
        string PhoneNumber { get; }

        //  Getter de la direccion de mail de la persona
        string EmailAddress { get; }

        //  Getter del id de la persona
        string Id { get; }

        //Getter de la ubicacion de una persona (coordenadas)
        Location Location { get; set;}

        //  Getter de la instancia servicio de una persona --> conoce el campo de trabajo, el trabajo mismo, su descripcion, y el precio esperado
        Service Service { get; }
    }
}