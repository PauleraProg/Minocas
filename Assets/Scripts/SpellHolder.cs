using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHolder : MonoBehaviour
{
    int totalSpell = 1;

    int currentIndex;

    public GameObject[] spells;

    public GameObject spellHolder;

    public GameObject currentSpell;

    private void Start()
    {
        totalSpell = spellHolder.transform.childCount;
        spells = new GameObject[totalSpell];

        for (int i = 0; i < totalSpell; i++)
        {
            spells[i] = spellHolder.transform.GetChild(i).gameObject;
            spells[i].SetActive(false);
        }
        spells[0].SetActive(true);
        currentSpell = spells[0];
        currentIndex = 0;
    }
}

