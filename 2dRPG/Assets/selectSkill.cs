using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;

public class selectSkill : MonoBehaviour

{

    public Image ancientScroll;
    public Dropdown fbDropdown, vbDropdown;
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
        vbDropdown.GetComponent<Dropdown>();


        
    }

    void Update()
    {
        //Flame bomb skill
        if (fbDropdown.options[fbDropdown.value].text != "None")
        {

            if (fbDropdown.value == 1)
            {
                var fbIcon = Resources.Load<Sprite>("Tazo_2D/Icon/fireBolt");
                f1Btn.image.sprite = fbIcon;
                var F1 = ("flameBomb");
            }

            if (fbDropdown.value == 2)
            {
                var fbIcon = Resources.Load<Sprite>("Tazo_2D/Icon/fireBolt");
                f2Btn.image.sprite = fbIcon;
                var F2 = ("flameBomb");
            }

            if (fbDropdown.value == 3)
            {
                var fbIcon = Resources.Load<Sprite>("Tazo_2D/Icon/fireBolt");
                f3Btn.image.sprite = fbIcon;
                var F3 = ("flameBomb");
            }

            if (fbDropdown.value == 4)
            {
                var fbIcon = Resources.Load<Sprite>("Tazo_2D/Icon/fireBolt");
                f4Btn.image.sprite = fbIcon;
                var F4 = ("flameBomb");
            }

            if (fbDropdown.value == 5)
            {
                var fbIcon = Resources.Load<Sprite>("Tazo_2D/Icon/fireBolt");
                f5Btn.image.sprite = fbIcon;
                var F5 = ("flameBomb");
            }

            if (fbDropdown.value == 6)
            {
                var fbIcon = Resources.Load<Sprite>("Tazo_2D/Icon/fireBolt");
                f6Btn.image.sprite = fbIcon;
                var F6 = ("flameBomb");
            }

            if (fbDropdown.value == 7)
            {
                var fbIcon = Resources.Load<Sprite>("Tazo_2D/Icon/fireBolt");
                f7Btn.image.sprite = fbIcon;
                var F7 = ("flameBomb");
            }

            if (fbDropdown.value == 8)
            {
                var fbIcon = Resources.Load<Sprite>("Tazo_2D/Icon/fireBolt");
                f8Btn.image.sprite = fbIcon;
                var F8 = ("flameBomb");
            }
        }


        if (vbDropdown.options[vbDropdown.value].text != "None")
        {
            if (vbDropdown.value == 1)
            {
                var vbIcon = Resources.Load<Sprite>("Tazo_2D/Icon/voidBall");
                f1Btn.image.sprite = vbIcon;
                var F1 = ("VoidBall");
            }

            if (vbDropdown.value == 2)
            {
                var vbIcon = Resources.Load<Sprite>("Tazo_2D/Icon/voidBall");
                f2Btn.image.sprite = vbIcon;
                var F2 = ("VoidBall");
            }

            if (vbDropdown.value == 3)
            {
                var vbIcon = Resources.Load<Sprite>("Tazo_2D/Icon/voidBall");
                f3Btn.image.sprite = vbIcon;
                var F3 = ("VoidBall");
            }

            if (vbDropdown.value == 4)
            {
                var vbIcon = Resources.Load<Sprite>("Tazo_2D/Icon/voidBall");
                f4Btn.image.sprite = vbIcon;
                var F4 = ("VoidBall");
            }

            if (vbDropdown.value == 5)
            {
                var vbIcon = Resources.Load<Sprite>("Tazo_2D/Icon/voidBall");
                f5Btn.image.sprite = vbIcon;
                var F5 = ("VoidBall");
            }

            if (vbDropdown.value == 6)
            {
                var vbIcon = Resources.Load<Sprite>("Tazo_2D/Icon/voidBall");
                f6Btn.image.sprite = vbIcon;
                var F6 = ("VoidBall");
            }

            if (vbDropdown.value == 7)
            {
                var vbIcon = Resources.Load<Sprite>("Tazo_2D/Icon/voidBall");
                f7Btn.image.sprite = vbIcon;
                var F7 = ("VoidBall");
            }

            if (vbDropdown.value == 8)
            {
                var vbIcon = Resources.Load<Sprite>("Tazo_2D/Icon/voidBall");
                f8Btn.image.sprite = vbIcon;
                var F8 = ("VoidBall");
            }
        }
        
    
    }
    




}
