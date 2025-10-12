using UnityEngine;

public class Collectable
{
    private string _nombre;
    public string Nombre
    {
        get
        {
            return _nombre;
        }
        set
        {

        }
    }
    private int _costo;
    public int Costo
    {
        get
        {
            return _costo;
        }
        set
        {

        }
    }

    public Collectable(string name, int cost)
    {
        name = Nombre;
        cost = Costo;
    }
}
