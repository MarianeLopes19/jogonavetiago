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

    private float estaAtirando = 0.0f;

    public GameObject laser;

    public Transform pontoodisparosimples;

    public KeyCode espaco = KeyCode.Space;

    public float tempodotiro = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
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

    IEnumerator tiro()
    {
        if (Input.GetKey(espaco) && Time.time > estaAtirando)
        {
            estaAtirando = Time.time + tempodotiro;
            GameObject tiro =  Instantiate(laser, pontoodisparosimples.position, pontoodisparosimples.rotation);
            tiro.GetComponent<SpriteRenderer>().sortingOrder = 10;


        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        throw new NotImplementedException();
    }
}
