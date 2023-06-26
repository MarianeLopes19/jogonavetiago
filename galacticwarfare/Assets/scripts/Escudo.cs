using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escudo : MonoBehaviour
{
    public int vida = 2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("deu certo");

        if (collision.CompareTag("leser"))
        {
            vida--;
            Destroy(collision.gameObject);
            
            if (vida <= 0)
            {
                Die();
            }
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
