using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Atirar : MonoBehaviour
{
    public GameObject spellPrefab;

    public static float xAxis;
    public static float xAxis2;
    public static SpriteRenderer srCast;

    static public bool p1Shot;
    static public bool p2Shot;


    public Transform offset;
    Rigidbody2D rb;
    LineRenderer lr;

    Vector2 dragStart;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lr = GetComponent<LineRenderer>();
        p1Shot = false;
        p2Shot = false;
        srCast = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Bola();

    }

    
    public void Bola()
    {
        xAxis = Input.GetAxis("P1");
        xAxis2 = Input.GetAxis("P2");

        if (xAxis < 0)
        {
            srCast.flipX = true;
        }
        else if (xAxis > 0)
        {
            srCast.flipX = false;
        }

        if (xAxis2 > 0)
        {
            srCast.flipX = true;
        }
        else if (xAxis2 < 0)
        {
            srCast.flipX = false;
        }

        if (!Turnos.playerTurn && gameObject.CompareTag("P1"))
        {
            if (!p1Shot && Input.GetKey(KeyCode.RightShift))
            {
                p1Shot = true;
                Movimento.isShooting = true;

                if (!srCast.flipX)
                {
                    Vector2 offset = new Vector2(transform.position.x + 2, transform.position.y + 2.5f);
                    Instantiate(spellPrefab, offset, Quaternion.identity);
                }
            }           

            if (!p1Shot && Input.GetKey(KeyCode.RightShift))
            {
                p1Shot = true;
                Movimento.isShooting = true;

                if (!srCast.flipX)
                {
                    Vector2 offset = new Vector2(transform.position.x + -2, transform.position.y + 2.5f);
                    Instantiate(spellPrefab, offset, Quaternion.identity);
                }
            }
        }
        else if (Turnos.playerTurn && gameObject.CompareTag("P2"))
        {
            if (!p2Shot && Input.GetKeyDown(KeyCode.LeftShift))
            {
                p2Shot = true;                
                Movimento.isShooting = true;
                if(!srCast.flipX)
                {
                    Vector2 offset = new Vector2(transform.position.x + -2, transform.position.y + 2.5f);
                    Instantiate(spellPrefab, offset, Quaternion.identity);
                }
                else
                {
                    Vector2 offset = new Vector2(transform.position.x + 2, transform.position.y + 2.5f);
                    Instantiate(spellPrefab, offset, Quaternion.identity);
                }
            }
        }
       
    }

}
