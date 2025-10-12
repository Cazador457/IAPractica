using UnityEngine;
using System.Collections.Generic;
public class Inventory
{
    private string _name;
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {

        }
    }
    private List<Collection> _generic;
    public List<Collection> Generic
    {
        get
        {
            return _generic;
        }
        set
        {

        }
    }

    public Inventory(string nombre)
    {
        nombre = Name;
    }
}