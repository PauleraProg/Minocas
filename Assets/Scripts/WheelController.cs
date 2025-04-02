using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WheelController : MonoBehaviour
{
    public int id;
    public string spellname;
    public TextMeshProUGUI spellText;
    public Image selectedSpell;
    private bool selected;
    public Sprite icon;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (selected)
        {
            selectedSpell.sprite = icon;
            spellText.text = spellname;
        }
    }

    public void Selected()
    {
        selected = true;
    }

    public void DeSelected()
    {
        selected = false;
    }

    public void HoverEnter()
    {
        if(selected)
        {
            spellText.text = spellname;
        }
    }

    public void HoverExit()
    {
        if (!selected)
        {
            spellText.text = "";
        }
    }
}
