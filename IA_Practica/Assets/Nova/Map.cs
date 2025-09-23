using UnityEngine;
using System.Collections.Generic;
public class Map
{
    public string name;
    public Vector2Int origen;
    public Vector2Int size;
    public Map(string nombre, Vector2Int baseorigen, Vector2Int basesize)
    {
        name = nombre;
        baseorigen = origen;
        basesize = size;
    }
}
