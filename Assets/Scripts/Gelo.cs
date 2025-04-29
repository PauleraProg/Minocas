using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Gelo : MonoBehaviour
{
    public float speed = 10f;

    static public float dano = 20f;

    private SpriteRenderer sRplayer;

    public bool flipped;

    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject;

        sRplayer = player.GetComponent<SpriteRenderer>();

        if (sRplayer.flipX)
        {
            flipped = true;
        }
        else
        {
            flipped = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();      
    }

    void Shoot()
    {
        if (gameObject.CompareTag("P1"))
        {
            if (flipped)
            {
                transform.position += -transform.right * speed * Time.deltaTime;
            }
            else
            {
                transform.position += transform.right * speed * Time.deltaTime;
            }
        }

        if (gameObject.CompareTag("P2"))
        {
            if (flipped)
            {
                transform.position += transform.right * speed * Time.deltaTime;
            }
            else
            {
                transform.position += -transform.right * speed * Time.deltaTime;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Turnos.turno += 1;
        Destroy(gameObject);
    }

   


}
