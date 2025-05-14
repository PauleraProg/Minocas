using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponHolder : MonoBehaviour
{
    int totalSpells;
    int totalIcons;

    int currentIndex;

    public GameObject[] spells;
    public Image[] icons; 

    public GameObject currentSpell;

    public Image selectedSpell;

    public Sprite noImage;

    public static int spellID;

    [SerializeField] private GameObject[] casts;



    private void Start()
    {
        totalSpells = gameObject.transform.childCount;
        spells = new GameObject[totalSpells];

        for (int i = 0; i < totalSpells; i++)
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
        Switching();
    }

    public void Fireball()
    {
        spells[currentIndex].SetActive(false);
        currentIndex = spellID;
        spells[currentIndex].SetActive(true);

        Debug.Log("is selecting");
    }

    public void IceCluster()
    {
        spells[currentIndex].SetActive(false);
        currentIndex = spellID;
        spells[currentIndex].SetActive(true);
    }

    public void LandSlide()
    {
        spells[currentIndex].SetActive(false);
        currentIndex = spellID;
        spells[currentIndex].SetActive(true);
    }

    public void ThunderStrike()
    {
        spells[currentIndex].SetActive(false);
        currentIndex = spellID;
        spells[currentIndex].SetActive(true);
    }

    public void Switching()
    {
        if (!Turnos.playerTurn)
        {
            casts[0].SetActive(true);
            casts[1].SetActive(false);
        }
        else if (Turnos.playerTurn)
        {
            casts[0].SetActive(false);
            casts[1].SetActive(true);
        }
    }
}

