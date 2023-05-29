using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barravida : MonoBehaviour
{
    public GameObject[] barrasVermelhas;

    public void ExibirVida(int vidas)
    {
        for (int i = 0; i < this.barrasVermelhas.Length; i++)
        {
            if (i < vidas)
            {
                this.barrasVermelhas[i].SetActive(true);
            }
            else
            {
                this.barrasVermelhas[i].SetActive(false);
            }
        }

    }
}
