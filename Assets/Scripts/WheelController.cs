using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WheelController : MonoBehaviour
{
    int totalSpell;

    int currentIndex;

    public GameObject[] spells;

    public GameObject currentSpell;

    public Animator anim;

    public bool weaponWheelOn = false;

    public Image selectedSpell;

    public Sprite noImage;

    public static int spellID;

    private void Start()
    {
        totalSpell = gameObject.transform.childCount;
        spells = new GameObject[totalSpell];

        for (int i = 0; i < totalSpell; i++)
        {
            spells[i] = gameObject.transform.GetChild(i).gameObject;
            spells[i].SetActive(false);
        }
        spells[0].SetActive(true);
        currentSpell = spells[0];
        currentIndex = 0;
    }

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
            default:
                spellID = spellID;
                break;

            case 1:
                

                    spellID = 1;
                    anim.SetBool("OpenWeaponWheel", false);
                
                break;

            case 2:
                break;
        }

    }

    
}
