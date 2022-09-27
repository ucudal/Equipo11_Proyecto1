using System;
using ClassLibrary;
using System.Collections;
using System.Collections.Generic;
namespace Locate

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
            personCoord["X"]= x;
            personCoord["Y"]=y;
        }
        IPerson person;
        private Dictionary<string,int> personCoord;
        
        /// <summary>
        /// Getter de la coordenada X
        /// </summary>
        /// <returns></returns>
        public int getX()
        {
            return personCoord["X"];
        }

        /// <summary>
        /// Getter de la coordenada Y
        /// </summary>
        /// <returns></returns>
        public int getY()
        {
            return personCoord["Y"];
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