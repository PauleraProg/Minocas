using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Atirar : MonoBehaviour
{
    public GameObject fireballPrefab;
    public GameObject thunderPrefab;

    private float xAxis;
    private float xAxis2;
    private SpriteRenderer srCast;

    static public bool p1Shot;
    static public bool p2Shot;

    private bool endTurn;

    //public Transform offset;

    
    // Start is called before the first frame update
    void Start()
    {
        p1Shot = false;
        p2Shot = false;
        srCast = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Unlock();
        Bola();        
    }

    void Unlock()
    {
        
        if(p1Shot || p2Shot)
        {
            endTurn = GameObject.FindGameObjectWithTag("Spell");
            
            if (!endTurn)
            {
               Movimento.isShooting = false;                
            }

            
        }
    }

    void Bola()
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

        if (gameObject.CompareTag("P1") && !Turnos.playerTurn)
        {
            if (!p1Shot && Input.GetKeyDown(KeyCode.RightControl))
            {
                if (srCast.flipX)
                {
                    Vector2 offset = new Vector2(transform.position.x + -2, transform.position.y + 2.5f);
                    Instantiate(fireballPrefab, offset, Quaternion.identity);
                }
                else
                {
                    Vector2 offset = new Vector2(transform.position.x + 2, transform.position.y + 2.5f);
                    Instantiate(fireballPrefab, offset, Quaternion.identity);
                }
                Movimento.isShooting = true;
                p1Shot = true;
            }

        }
        else if (gameObject.CompareTag("P2") && Turnos.playerTurn)
        {
            if (!p2Shot && Input.GetKeyDown(KeyCode.LeftControl))
            {
                if(!srCast.flipX)
                {
                    Vector2 offset = new Vector2(transform.position.x + -2, transform.position.y + 2.5f);
                    Instantiate(fireballPrefab, offset, Quaternion.identity);
                }
                else
                {
                    Vector2 offset = new Vector2(transform.position.x + 2, transform.position.y + 2.5f);
                    Instantiate(fireballPrefab, offset, Quaternion.identity);
                }
                Movimento.isShooting = true;
                p2Shot = true;
            }
        }
    }

    void Lampago()
    {
         
    }
}
