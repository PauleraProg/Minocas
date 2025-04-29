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
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            weaponWheelOn = !weaponWheelOn;
        }

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
