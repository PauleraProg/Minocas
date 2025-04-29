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

    private void Update()
    {       
        
    }

    public void Fireball()
    {
        spells[currentIndex].SetActive(false);
        currentIndex = spellID;
        spells[currentIndex].SetActive(true);
    }

    public void IceCluster()
    {
        spells[currentIndex].SetActive(false);
        currentIndex = spellID;
        spells[currentIndex].SetActive(true);
    }
}

