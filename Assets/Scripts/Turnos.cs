using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turnos : MonoBehaviour
{
    static public int turno = 1;
    static public bool playerTurn;
    private bool action;


    // Start is called before the first frame update
    void Start()
    {
        playerTurn = false;
    }

    // Update is called once per frame
    void Update()
    {           
        BulletCheck();
        if (action)
        {
            Action();
        }
        OpenFire();
            ManageTurn(turno);        
    }

    static public bool ManageTurn(int turn)
    {
        if (turn % 2 == 0)
        {
            playerTurn = true;
        }
        else
        {
            playerTurn = false;
        }

        return playerTurn;
    } 

    void Action()
    {           
            Debug.Log(turno);
    }

    void BulletCheck()
    {
        action = GameObject.FindGameObjectWithTag("Spell");
    }

    void OpenFire()
    {
        if (!playerTurn)
        {
            Movimento.isShooting = false;
            Atirar.p1Shot = false;
        }
        else
        {
            Movimento.isShooting = false;
            Atirar.p2Shot = false;
        }
    }
}
