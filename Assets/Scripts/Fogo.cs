using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Fogo : MonoBehaviour
{
    static public float speed = 20f;

    static public int dano = 15;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);      
    }

    private void OnDestroy()
    {
        Turnos.turno++;
    }
}
