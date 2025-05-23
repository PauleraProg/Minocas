using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconControl : MonoBehaviour
{
    int totalIcons;
    public GameObject[] icons;
    int currentIndex;
    // Start is called before the first frame update
    void Start()
    {
        totalIcons = gameObject.transform.childCount;
        icons = new GameObject[totalIcons];

        for (int i = 0; i < totalIcons; i++)
        {
            icons[i] = gameObject.transform.GetChild(i).gameObject;
            icons[i].SetActive(false);
        }
        icons[0].SetActive(true);
        currentIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        SpriteUi();
    }

    public void SpriteUi()
    {
        if (gameObject.CompareTag("P1"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
               icons[currentIndex].gameObject.SetActive(false);
               currentIndex++;
               if(currentIndex > 3)
               {
                        currentIndex = 0;
               }
               icons[currentIndex].gameObject.SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                icons[currentIndex].gameObject.SetActive(false);
                currentIndex--;
                if (currentIndex < 0)
                {
                    currentIndex = 3;
                }
                icons[currentIndex].gameObject.SetActive(true);
            }
        }

        if (gameObject.CompareTag("P2"))
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                icons[currentIndex].gameObject.SetActive(false);
                currentIndex++;
                icons[currentIndex].gameObject.SetActive(true);

                if (currentIndex >= 4)
                {
                    icons[currentIndex].gameObject.SetActive(false);
                    currentIndex = 0;
                    icons[currentIndex].gameObject.SetActive(true);
                }
            }

            if (Input.GetKeyDown(KeyCode.I))
            {
                icons[currentIndex].gameObject.SetActive(false);
                currentIndex--;
                icons[currentIndex].gameObject.SetActive(true);

                if (currentIndex <= -1)
                {
                    icons[currentIndex].gameObject.SetActive(false);
                    currentIndex = 0;
                    icons[currentIndex].gameObject.SetActive(true);
                }
            }
        }
    }
}
