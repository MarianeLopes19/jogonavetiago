
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ControleDoJogador : MonoBehaviour
{
    public Rigidbody2D forcaFisica;
    public float ligeirezaDaNabe;
    
    private Vector2 direcaoDaNave;

    public float estaAtirando = 0.0f;

    public GameObject laser;

    public Transform pontoodisparosimples;

    public KeyCode espaco = KeyCode.Space;

    public float tempodotiro = 10f;

    public int vidaInicial = 5;

    public int energiaInicial = 5;

    private int vida;

    private int energia;
    
    // Start is called before the first frame update
    void Start()
    {
        vida = vidaInicial;
        energia = energiaInicial;
        ControleDaVida.instance.UpdateLives(vida);
        ControleDaVida.instance.UpdateEnergy(energia);
        ControladorPontuacao.Pontuacao = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tirosimples();
    }

    private void FixedUpdate()
    {
        locomocaoDaNave();
    }

    private void locomocaoDaNave()
    {
        direcaoDaNave = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        forcaFisica.velocity = direcaoDaNave.normalized * ligeirezaDaNabe;
    }

    void tirosimples()
    {
        StartCoroutine("tiro");
    }

    void tiro()
    {
        if (Input.GetKey(espaco) && Time.time > estaAtirando)
        {
            estaAtirando = Time.time + tempodotiro;
            GameObject tiro =  Instantiate(laser, pontoodisparosimples.position, pontoodisparosimples.rotation);
            tiro.GetComponent<SpriteRenderer>().sortingOrder = 10;


        }
    }

    public void Damage(int dmg)
    {
        energia--;
        ControleDaVida.instance.UpdateEnergy(energia);
        
        if (energia <= 0)
        {
            // chamar game Over
            vida--;
            ControleDaVida.instance.UpdateLives(vida);
            if (vida > 0)
            {
                energia = energiaInicial;
                ControleDaVida.instance.UpdateEnergy(energia);
            }
        }
    }
}
