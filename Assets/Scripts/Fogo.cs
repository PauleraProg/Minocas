using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fogo : MonoBehaviour
{
    public float speed = 7f;
    static public float dano = 15f;
    public Rigidbody2D fireAll;

    

    // Start is called before the first frame update
    void Start()
    {
        fireAll = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += Atirar.offset.position * Time.deltaTime * speed;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
