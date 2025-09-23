using UnityEngine;

public enum Ability { Dash, Run, DobleJump, WallJump };

public class Player : Character
{
    public Inventory inventory;
    public Stats stadistics;
    public Ability ability;

    public void PlayerMovement()
    {

    }   
}
