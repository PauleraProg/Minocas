using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WheelController : MonoBehaviour
{
    public Animator anim;

    public bool weaponWheelOn = false;

    public Image selectedSpell;

    public Sprite noImage;
    [SerializeField] private Atirar shoot;

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

    }

    
}
