using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIController : MonoBehaviour
{
    public GameObject UIpanel;
    public float showTime = 5f;
    public bool show = false;

    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O) && !show)
        {
            StartCoroutine(ShowUI());
        }
    }
    IEnumerator ShowUI()
    {
        show = true;
        UIpanel.SetActive(true);
        yield return new WaitForSeconds(showTime);
        UIpanel.SetActive(false);
        show = false;
    }
}
