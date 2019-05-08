using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;

public class selectSkill : MonoBehaviour

{

    public Image ancientScroll;
    public Dropdown fbDropdown;
    public Button f1Btn;
    public Button f2Btn;
    public Button f3Btn;
    public Button f4Btn;
    public Button f5Btn;
    public Button f6Btn;
    public Button f7Btn;
    public Button f8Btn;


    void Awake ()
    {
        ancientScroll.GetComponent<Image>();
        fbDropdown.GetComponent<Dropdown>();
        f1Btn.GetComponent<Image>();

        
    }

    void Update()
    {
        //Flame bomb skill

        if(fbDropdown.value == 1)
        {
            var fbIcon = Resources.Load<Sprite>("Tazo_2D/Icon/flameBombImg");
            f1Btn.image.sprite = fbIcon;
            var F1 = ("flameBomb");
        } else
        {
            f1Btn.image.sprite = null;
            var F1 = ("");
        }

        if (fbDropdown.value == 2)
        {
            var fbIcon = Resources.Load<Sprite>("Tazo_2D/Icon/flameBombImg");
            f2Btn.image.sprite = fbIcon;
            var F2 = ("flameBomb");
        }
        else
        {
            f2Btn.image.sprite = null;
            var F2 = ("");
        }

        if (fbDropdown.value == 3)
        {
            var fbIcon = Resources.Load<Sprite>("Tazo_2D/Icon/flameBombImg");
            f3Btn.image.sprite = fbIcon;
            var F3 = ("flameBomb");
        }
        else
        {
            f3Btn.image.sprite = null;
            var F3 = ("");
        }

        if (fbDropdown.value == 4)
        {
            var fbIcon = Resources.Load<Sprite>("Tazo_2D/Icon/flameBombImg");
            f4Btn.image.sprite = fbIcon;
            var F4 = ("flameBomb");
        }
        else
        {
            f4Btn.image.sprite = null;
            var F4 = ("");
        }

        if (fbDropdown.value == 5)
        {
            var fbIcon = Resources.Load<Sprite>("Tazo_2D/Icon/flameBombImg");
            f5Btn.image.sprite = fbIcon;
            var F5 = ("flameBomb");
        }
        else
        {
            f5Btn.image.sprite = null;
            var F5 = ("");
        }

        if (fbDropdown.value == 6)
        {
            var fbIcon = Resources.Load<Sprite>("Tazo_2D/Icon/flameBombImg");
            f6Btn.image.sprite = fbIcon;
            var F6 = ("flameBomb");
        } else
        {
            f6Btn.image.sprite = null;
            var F6 = ("");
        }

        if (fbDropdown.value == 7)
        {
            var fbIcon = Resources.Load<Sprite>("Tazo_2D/Icon/flameBombImg");
            f7Btn.image.sprite = fbIcon;
            var F7 = ("flameBomb");
        } else
        {
            f7Btn.image.sprite = null;
            var F7 = ("");
        }

        if (fbDropdown.value == 8)
        {
            var fbIcon = Resources.Load<Sprite>("Tazo_2D/Icon/flameBombImg");
            f8Btn.image.sprite = fbIcon;
            var F8 = ("flameBomb");
        } else
        {
            f8Btn.image.sprite = null;
            var F8 = ("");
        }

    }




}
