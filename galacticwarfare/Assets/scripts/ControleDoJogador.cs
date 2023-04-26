using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDoJogador : MonoBehaviour
{
    public Rigidbody2D forcaFisica;
    public float ligeirezaDaNabe;
    
    private Vector2 direcaoDaNave;

    private bool estaAtirando;

    public GameObject laser;

    public Transform pontoodisparosimples;
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
        if (Input.GetKeyDown(KeyCode.Y))
        {
            estaAtirando = true;
            Instantiate(laser, pontoodisparosimples.position, pontoodisparosimples.rotation);
            yield return new WaitForSeconds(0.2f);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        throw new NotImplementedException();
    }
}
