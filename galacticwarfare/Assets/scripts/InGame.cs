using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGame : MonoBehaviour
{
    public Text textoPontuacao;
    
    // Update is called once per frame
    void Update()
    {
        this.textoPontuacao.text = ControladorPontuacao.Pontuacao.ToString();
    }
}
