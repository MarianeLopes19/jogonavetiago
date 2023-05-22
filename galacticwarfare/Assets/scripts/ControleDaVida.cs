using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControleDaVida : MonoBehaviour
{
    public Text healthTexr;

    public static ControleDaVida instance;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateLives(int value)
    {
        healthTexr.text = "x" + value.ToString();
    }
}
