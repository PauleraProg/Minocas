using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponHolder : MonoBehaviour
{
    int totalSpells;

    int currentIndex;

    public GameObject[] spells;

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
        NewEquip();
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

    public void NewEquip()
    {
        if (gameObject.CompareTag("P1"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                spells[currentIndex].gameObject.SetActive(false);
                currentIndex++;
                spells[currentIndex].gameObject.SetActive(true);

                if (currentIndex >= spells.Length && Input.GetKeyDown(KeyCode.E))
                {
                    spells[currentIndex].gameObject.SetActive(false);
                    currentIndex = 0;
                    spells[currentIndex].gameObject.SetActive(true);
                }
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                spells[currentIndex].gameObject.SetActive(false);
                currentIndex--;
                spells[currentIndex].gameObject.SetActive(true);

                if (currentIndex <= spells.Length && Input.GetKeyDown(KeyCode.Q))
                {
                    spells[currentIndex].gameObject.SetActive(false);
                    currentIndex = 0;
                    spells[currentIndex].gameObject.SetActive(true);
                }
            }
        }

        if (gameObject.CompareTag("P2"))
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                spells[currentIndex].gameObject.SetActive(false);
                currentIndex++;
                spells[currentIndex].gameObject.SetActive(true);

                if (currentIndex >= spells.Length && Input.GetKeyDown(KeyCode.E))
                {
                    spells[currentIndex].gameObject.SetActive(false);
                    currentIndex = 0;
                    spells[currentIndex].gameObject.SetActive(true);
                }
            }

            if (Input.GetKeyDown(KeyCode.I))
            {
                spells[currentIndex].gameObject.SetActive(false);
                currentIndex--;
                spells[currentIndex].gameObject.SetActive(true);

                if (currentIndex <= spells.Length && Input.GetKeyDown(KeyCode.Q))
                {
                    spells[currentIndex].gameObject.SetActive(false);
                    currentIndex = 0;
                    spells[currentIndex].gameObject.SetActive(true);
                }
            }
        }
    }
}


