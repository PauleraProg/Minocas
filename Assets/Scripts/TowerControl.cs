using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerControl : MonoBehaviour
{
    private int integrity = 25;
    private int integrity2 = 25;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        if (integrity <= 0) 
        {
            Destroy(gameObject);
        }

        if (integrity2 <= 0) 
        {
            Destroy(gameObject);
        }    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Spell"))
        {
            if (gameObject.CompareTag("P1"))
            {
                integrity--;
            }
            else if (gameObject.CompareTag("P2"))
            {
                integrity2--;
            } 
        }
        Debug.Log(integrity);
    }
}
