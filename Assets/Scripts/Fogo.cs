using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Fogo : MonoBehaviour
{
    public float speed = 20f;

    static public int dano = 15;

    private SpriteRenderer sRplayer;

    public bool flipped;

    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
        player = GameObject.FindGameObjectWithTag("P1");

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
        if (flipped)
        {
            transform.position += -transform.right * speed * Time.deltaTime;
        }
        else
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Turnos.turno += 1;
        Atirar.p1Shot = false;
        Destroy(gameObject);
    }
}
