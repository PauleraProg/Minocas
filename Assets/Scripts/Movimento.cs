using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    public float speed = 2.5f;

    public float jump = 3;

    static public int vida = 100;

    private Rigidbody2D rB;

    private SpriteRenderer sR;

    private float xAxis1;
    private float xAxis2;

    public GameObject offset;

    static public bool isShooting;

    // Start is called before the first frame update
    void Start()
    {
        isShooting = false;
        rB = GetComponent<Rigidbody2D>();
        sR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
        Movement();     
    }

    void Movement()
    {
        if (gameObject.CompareTag("P1") && !Turnos.playerTurn)
        {
            xAxis1 = Input.GetAxis("P1");

            if (xAxis1 < 0)
            {
                sR.flipX = true;
            }
            else if (xAxis1 > 0)
            {
                sR.flipX = false;
            }
            
            if (!isShooting)
            {
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    transform.Translate(new Vector2(speed * Time.deltaTime, 0));

                }
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    transform.Translate(new Vector2(-speed * Time.deltaTime, 0));

                }
            }
        }
        else if (gameObject.CompareTag("P2") && Turnos.playerTurn)
        {
            xAxis2 = Input.GetAxis("P2");

            if (xAxis2 < 0)
            {
                sR.flipX = false;
            }
            else if (xAxis2 > 0)
            {
                sR.flipX = true;
            }

            if (!isShooting)
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
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Spell"))
        {
            vida -= Fogo.dano;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Spell"))
        {
            vida -= Raio.dano;
        }
    }
}


