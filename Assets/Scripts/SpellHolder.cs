using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponHolder : MonoBehaviour
{
    int totalSpell;

    int currentIndex;

    public GameObject[] spells;

    public GameObject currentSpell;

    public Image selectedSpell;

    public Sprite noImage;

    public Animator anim;

    public bool weaponWheelOn = false;

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
        currentIndex = 0;
    }

    private void Update()
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
                spells[0].SetActive(true);
                break;
            case 1:
                Debug.Log("Ice Clusters!");
                break;
        }
    }




}

