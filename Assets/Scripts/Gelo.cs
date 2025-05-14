using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Gelo : MonoBehaviour
{
    public float speed = 10f;

    static public float dano = 20f;
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
