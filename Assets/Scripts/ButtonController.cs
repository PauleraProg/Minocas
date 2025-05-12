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
            spellText.text = spellname;
        }
    }

    public void Selected()
    {
        selected = true;
        WeaponHolder.spellID = ID;
    }

    public void DeSelected()
    {
        selected = false;
        WeaponHolder.spellID = 0;
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
