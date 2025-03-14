using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    public float speed = 2.5f;
    public float jump = 3;
    private float vida = 100;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (gameObject.CompareTag("P1"))
        {
            
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(new Vector2(speed * Time.deltaTime, 0));
                transform.localScale = new Vector2(1.9112f, 1.5467f);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(new Vector2(-speed * Time.deltaTime, 0));
                transform.localScale = new Vector2(-1.9112f, 1.5467f);
            }
        }
        else if (gameObject.CompareTag("P2"))
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(new Vector2(speed * Time.deltaTime, 0));
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(new Vector2(-speed * Time.deltaTime, 0));
            }

        }
        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Fireball"))
        {
            vida -= Fogo.dano;
        }

        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}


