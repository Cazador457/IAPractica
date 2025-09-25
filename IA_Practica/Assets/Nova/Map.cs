using UnityEngine;
using System.Collections.Generic;
public class Map
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
    private Vector2Int _origen;
    public Vector2Int Origen
    {
        get
        {
            return _origen;
        }
        set
        {

        }
    }
    private Vector2Int _size;
    public Vector2Int Size
    {
        get
        {
            return _size;
        }
        set
        {

        }
    }

    public Map(string nombre, Vector2Int baseorigen, Vector2Int basesize)
    {
        nombre = Name;
        baseorigen = Origen;
        basesize = Size;
    }
}
