using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barradevida : MonoBehaviour
{
    public GameObject[] barrasVermelhas;

    private Color opaque = new Color(1, 1, 1, 1);
    private Color transparent = new Color(0, 0, 0, 0);
    
    public void ExibirVida(int vidas)
    {
        for (int i = 0; i < this.barrasVermelhas.Length; i++)
        {
            if (i < vidas)
            {
                this.barrasVermelhas[i].GetComponent<Image>().color = opaque;
            }
            else
            {
                this.barrasVermelhas[i].GetComponent<Image>().color = transparent;
            }
        }

    }
}
