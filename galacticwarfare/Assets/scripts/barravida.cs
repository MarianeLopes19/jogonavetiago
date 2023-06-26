using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barravida : MonoBehaviour
{
    public GameObject[] barrasVermelhas;

    public void ExibirVida(int vidas)
    {
        for (int i = 0; i < this.barrasVermelhas.Length; i++) //peco. desde a posiçao inicial 0 ate o tamanho total dele
        {
            if (i < vidas) // ativar barra vermelha.. se eu quiser exibir as 5 vidas vou exibir todas ate a posicao menor q 5
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
