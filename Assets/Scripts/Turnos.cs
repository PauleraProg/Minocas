using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turnos : MonoBehaviour
{
    static public int turno;
    static public bool playerTurn;

    // Start is called before the first frame update
    void Start()
    {
        turno = 1;
        playerTurn = false;
    }

    // Update is called once per frame
    void Update()
    {
        OpenFire();
        ManageTurn(turno);        
    }

    static public bool ManageTurn(int turn)
    {
        if (turn % 2 == 0)
        {
            playerTurn = true;
        }
        else if (turn % 2 != 0)
        {
            playerTurn = false;
        }

        return playerTurn;
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
