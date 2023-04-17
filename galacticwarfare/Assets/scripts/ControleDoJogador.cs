using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDoJogador : MonoBehaviour
{
    public Rigidbody2D forcaFisica;
    public float ligeirezaDaNabe;

    private Vector2 direcaoDaNave;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        locomocaoDaNave();
    }

    private void locomocaoDaNave()
    {
        direcaoDaNave = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        forcaFisica.velocity = direcaoDaNave.normalized * ligeirezaDaNabe;
    }
}
