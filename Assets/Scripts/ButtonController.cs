using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonController : MonoBehaviour
{
    public int ID;
    private Animator anim;
    public string spellname;
    public TextMeshProUGUI spellText;
    public Image selectedSpell;
    private bool selected = false;
    public Sprite icon;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
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
        WheelController.spellID = ID;
    }

    public void DeSelected()
    {
        selected = false;
        WheelController.spellID = 0;
    }

    public void HoverEnter()
    {
        anim.SetBool("Hover", true);
        spellText.text = spellname;
    }

    public void HoverExit()
    {
        anim.SetBool("Hover", false);
        spellText.text = "";
    }
}
