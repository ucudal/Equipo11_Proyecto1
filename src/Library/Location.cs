// Juan Magrini

using System;
using ClassLibrary;
using System.Collections;
using System.Collections.Generic;
namespace ClassLibrary

{
    /// <summary>
    /// Esta clase se encarga de guardar las coordenadas de una persona en objeto
    /// </summary>
    public class Location
    {
        
        /// <summary>
        /// Constructor de la clase Location
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        public Location(int latitude, int longitude)
        {
            this.Latitude= latitude;
            this.Longitude= longitude;
        }
        IPerson person;

        /// <summary>
        /// Coordenada de Latitud
        /// </summary>
        /// <value></value>
        public int Latitude {get;set;}
        /// <summary>
        /// Coordenada de longitud
        /// </summary>
        /// <value></value>
        public int Longitude {get;set;}
    }

}