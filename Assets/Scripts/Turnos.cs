using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turnos : MonoBehaviour
{
    static public int turno;
    static public bool playerTurn;
    private bool action;
    


    // Start is called before the first frame update
    void Start()
    {
        
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
    }

    static public bool ManageTurn(int turno)
    {        
        return playerTurn;
    }

    void Action()
    {           
            Debug.Log(turno);
            ManageTurn(turno);        
    }

    void BulletCheck()
    {
        action = GameObject.FindGameObjectWithTag("Spell");
    }

    void OpenFire()
    {
        if (!playerTurn)
        {
            Atirar.p1Shot = false;
        }
        else
        {
            Atirar.p2Shot = false;
        }
    }
}
