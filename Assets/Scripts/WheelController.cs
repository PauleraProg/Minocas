using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WheelController : MonoBehaviour
{
    public Animator anim;

    private bool weaponWheelOn = false;

    public Image selectedSpell;

    public Sprite noImage;

    public static int spellID;

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

        switch (spellID)
        {
            case 0:
                selectedSpell.sprite = noImage;
                break;
        }
    }

    
}
