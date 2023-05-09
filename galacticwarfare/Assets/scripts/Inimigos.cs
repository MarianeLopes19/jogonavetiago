using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigos : MonoBehaviour
{
    private Rigidbody2D rig;
    public float tempoAparecer;
    public Inimigos CaçaEstelar;
    public Inimigos NaveAtque;
    public Inimigos CruzadorBatalha;
    public Inimigos Chefe;
    
    

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        
        Destroy(gameObject, 80f);
    }
    
    private void Update()
    {
        tempoAparecer += Time.deltaTime;
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (tempoAparecer >= 5)
        {
            rig.velocity = Vector2.right * speed;
        }
        
        
        
    }


    
    
}
