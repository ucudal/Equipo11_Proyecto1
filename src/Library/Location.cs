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
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Location(int x, int y)
        {
            this.PersonCoord= new Dictionary<string, int> {{"X", x}, {"Y", y}};
        }
        IPerson person;

        /// <summary>
        /// Diccionario cuyas claves son X e Y, y sus valores son los valores respectivos a cada coordenada
        /// </summary>
        /// <value></value>
        public Dictionary<string,int> PersonCoord {get; set;}
        
        /// <summary>
        /// Getter de la coordenada X
        /// </summary>
        /// <returns></returns>
        public int getX()
        {
            return PersonCoord["X"];
        }

        /// <summary>
        /// Getter de la coordenada Y
        /// </summary>
        /// <returns></returns>
        public int getY()
        {
            return PersonCoord["Y"];
        }

        /// <summary>
        /// Getter de la ubicacion en formato [X, Y]
        /// </summary>
        /// <returns></returns>
        public string getLocation()
        {
            return $"{person.Name} Location = {getX()},{getY()}";
        }
    }

}