using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelAnim : MonoBehaviour
{

    public Animator anim;

    public bool weaponWheelOn = false;

    // Update is called once per frame
    void Update()
    {
        WheelControl();
    }

    public void ClickClose()
    {
        weaponWheelOn = false;
    }

    void WheelControl()
    {
        if (!Turnos.playerTurn && Input.GetKeyDown(KeyCode.LeftControl))
        {
          
            weaponWheelOn = !weaponWheelOn;
            

            if (weaponWheelOn)
            {
                anim.SetBool("OpenWeaponWheel", true);
            }
            else
            {
                anim.SetBool("OpenWeaponWheel", false);
            }
        }

        if (Turnos.playerTurn && Input.GetKeyDown(KeyCode.RightControl))
        {
            
            weaponWheelOn = !weaponWheelOn;
            

            if (weaponWheelOn)
            {
                anim.SetBool("OpenWeaponWheel", true);
            }
            else
            {
                anim.SetBool("OpenWeaponWheel", false);
            }
        }
    }
}
