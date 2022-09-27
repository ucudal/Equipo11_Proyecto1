using System;
using System.Collections;
using ClassLibrary;
using System.Collections.Generic;
public class Location
{
    IPerson person;
    private Dictionary<string,int> personCoord;
    public Location(int x, int y)
    {
        personCoord["X"]= x;
        personCoord["Y"]=y;
    }

    public string getLocation()
    {
        return $"{person.Name} Location = {personCoord["X"]},{personCoord["Y"]}";
    }
}
