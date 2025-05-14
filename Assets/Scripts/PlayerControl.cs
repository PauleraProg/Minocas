using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public int vidaP1 = 100;
    public int vidaP2 = 100;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (vidaP1 <= 0 || vidaP2 <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("EndScreen");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            vidaP1 -= 1;
        }

        if (collision.gameObject.CompareTag("Spell"))
        {
            vidaP1 -= 1;
        }
    }

}
