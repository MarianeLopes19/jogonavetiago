using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControleDaVida : MonoBehaviour
{
    public Text healthText;

    public static ControleDaVida instance;

    public Barradevida barradevida;

    private ControleDoJogador jogador;

    private void Start()
    {
        this.jogador = GameObject.FindGameObjectWithTag("Player").GetComponent<ControleDoJogador>();
    }

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
        healthText.text = "x " + value.ToString();
    }

    public void UpdateEnergy(int value)
    {
        barradevida.ExibirVida(value);
    }
}
