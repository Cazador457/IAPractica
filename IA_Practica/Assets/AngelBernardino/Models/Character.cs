using UnityEngine;

public class Character
{
    private int _health;
    public int healt
    {
        get
        {
            return _health;
        }
        set
        {

        }
    }
    private float _velocityMovement;
    public float velocityMovement
    {
        get
        {
            return _velocityMovement;
        }
        set
        {

        }
    }
    private float _damageHit;
    public float damageHit
    {
        get
        {
            return _damageHit;
        }
        set
        {

        }
    }
    private float _jumpHeight;
    public float jumpHeight
    {
        get
        {
            return _jumpHeight;
        }
        set
        {

        }
    }
    private float _cooldown;
    public float colldown
    {
        get
        {
            return _cooldown;
        }
        set
        {

        }
    }
    public Character(float velocity, float jump)
    {
        velocityMovement = velocity;
        jumpHeight = jump;
    }
}
