using UnityEngine;
using System.Collections.Generic;

public enum Ability { Dash, Run, DobleJump, WallJump };

public class Player : Character
{
    public static Player Instance { get; private set; }
    private List<Ability> _ability = new List<Ability>();
    private Dictionary<string, Inventory> _inventory = new Dictionary<string, Inventory>();
    private Stats _stadistics;

    private Rigidbody2D rb { get; set; }
    private Vector2 moveVector;

    public List<Ability> ability
    {
        get
        {
            return _ability;
        }
    }
    public Dictionary<string, Inventory> inventory
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
    public void AddNewAbility()
    {

    }

    public Player(Rigidbody2D rb) : base(5, 5)
    {
        this.rb = rb;
        moveVector = new Vector2();
    }
    public void PlayerMovement(bool isGrounded)
    {
        moveVector = rb.linearVelocity;
        moveVector.x = 0;
        if (Input.GetKey(KeyCode.D)) moveVector.x = 1;

        if (Input.GetKey(KeyCode.A)) moveVector.x = -1;

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) moveVector.y = jumpHeight;

        moveVector.x *= velocityMovement;
        rb.linearVelocity = moveVector;
    }
}
