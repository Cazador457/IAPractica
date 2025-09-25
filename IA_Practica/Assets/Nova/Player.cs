using UnityEngine;
using System.Collections.Generic;

public enum Ability { Dash, Run, DobleJump, WallJump };

public class Player : Character
{
    public static Player Instance { get; private set; }
    private List<Ability> _ability = new List<Ability>();
    private Dictionary<string,Inventory> _inventory = new Dictionary<string,Inventory>();
    private Stats _stadistics;

    public List<Ability> ability
    {
        get
        {
            return _ability;
        }
    }
    public Dictionary<string,Inventory> inventory
    {
        get
        {
            return _inventory;
        }
    }
    public Stats Stats
    {
        get
        {
            return _stadistics;
        }
    }

    public static void CreateInstance()
    {
        if(Instance==null)
        {
            Instance=new Player();
        }
    }

    public void PlayerMovement()
    {

    }
    public void AddNewAbility()
    {

    }
}
