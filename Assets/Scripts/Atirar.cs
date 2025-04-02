using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Atirar : MonoBehaviour
{
    public GameObject fireballPrefab;
    public GameObject lghtPrefab;

    private float xAxis;
    private float xAxis2;
    private SpriteRenderer srCast;

    static public bool p1Shot;
    static public bool p2Shot;

    private bool endTurn;
    private bool liveSpell;

    //public Transform offset;

    
    // Start is called before the first frame update
    void Start()
    {
        liveSpell = false;
        p1Shot = false;
        p2Shot = false;
        srCast = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Bola();

        liveSpell = GameObject.FindGameObjectWithTag("Spell");
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

        if (!Turnos.playerTurn && gameObject.CompareTag("P1"))
        {
            if (!p1Shot && Input.GetKeyDown(KeyCode.RightControl))
            {
                p1Shot = true;
                Movimento.isShooting = true;
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
            }           
        }
        else if (Turnos.playerTurn && gameObject.CompareTag("P2"))
        {
            if (!p2Shot && Input.GetKeyDown(KeyCode.LeftControl))
            {
                p2Shot = true;                
                Movimento.isShooting = true;
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
            }
        }

        void Relampago()
        {
            if (!Turnos.playerTurn && gameObject.CompareTag("P1"))
            {
                if (!p1Shot && Input.GetKeyDown(KeyCode.LeftShift))
                {
                    p1Shot = true;
                    Movimento.isShooting = true;

                    
                }
            }
        }
    }


}
