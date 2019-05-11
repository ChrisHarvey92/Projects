using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hideSkillScroll : MonoBehaviour
{

    public Image skillScroll;
    public Canvas skillList;
    public shooting shootingScript;
    // Start is called before the first frame update
    void Start()
    {
        skillScroll.GetComponent<Image>();
        skillScroll.enabled = false;
        skillList.GetComponent<Canvas>();
        skillList.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (skillScroll.enabled == false)
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                skillScroll.enabled = true;
                skillList.enabled = true;
                shootingScript.enabled = false;
            }
        }
        else if (skillScroll.enabled == true)
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                skillScroll.enabled = false;
                skillList.enabled = false;
                shootingScript.enabled = true;

            }
        }
        }
        
    }

