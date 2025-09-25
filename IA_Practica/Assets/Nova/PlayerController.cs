using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance { get; private set; }
    void Awake()
    {
        if (Instance != null && Instance != this)
        { 
            Destroy(this.gameObject);
        }
        else 
        { 
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
            Player.CreateInstance();
        }
        
    }
}
