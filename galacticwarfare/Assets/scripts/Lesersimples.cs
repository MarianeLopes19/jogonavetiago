using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesersimples : MonoBehaviour
{
    private Rigidbody2D rig;

    public float speed;

    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rig.velocity = Vector2.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "inimigo")
        {
            Inimigos inimigos = collision.GetComponent<Inimigos>();
            inimigos.Destruir();
            collision.GetComponent<Inimigos>().Damage(damage);
            Destroy(gameObject);
        }
    }
}

