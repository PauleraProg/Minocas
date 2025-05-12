using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    static public int health = 100;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(health);
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("EndScreen");
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.CompareTag("Ground"))
        {
            health = 0;
        }

        else if (gameObject.CompareTag("Spell"))
        {
            health -= Fogo.dano;
        }

        Debug.Log(health);
    }

}
