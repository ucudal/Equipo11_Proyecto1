using System;
using ClassLibrary;
using System.Collections;
using System.Collections.Generic;
namespace Locate
{
    public class Location
    {
        IPerson person;
        private Dictionary<string,int> personCoord;
        public Location(int x, int y)
        {
            personCoord["X"]= x;
            personCoord["Y"]=y;
        }

        public int getX()
        {
            return personCoord["X"];
        }

        public int getY()
        {
            return personCoord["Y"];
        }

        public string getLocation()
        {
            return $"{person.Name} Location = {personCoord["X"]},{personCoord["Y"]}";
        }
    }

}