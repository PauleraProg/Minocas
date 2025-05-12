using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private GameObject spell;
    public float smoothness;
    public Vector2 limiteMin;
    public Vector2 limiteMax;

    private float largura;
    private float altura;

    // Start is called before the first frame update
    void Start()
    {
        Camera cam = Camera.main;
        altura = cam.orthographicSize;
        largura = cam.aspect * altura;
    }

    // Update is called once per frame
    void Update()
    {
        SpellFocus();
    }

    void PlayerFocus()
    {
        if (!Turnos.playerTurn)
        {
            gameObject.transform.position = new Vector3(1, 12.8f,-10);
        }
        else
        {
            gameObject.transform.position = new Vector3(45, 12.8f,-10);
        }
    }

    void SpellFocus()
    {
        spell = GameObject.FindGameObjectWithTag("Spell");
        if (spell != null)
        {
            transform.position = new Vector3 (spell.transform.position.x, spell.transform.position.y, -10);
        }
        else
        {
            PlayerFocus();
        }
    }
}
