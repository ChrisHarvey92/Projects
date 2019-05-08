using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hideSkillScroll : MonoBehaviour
{

    public Image skillScroll;
    // Start is called before the first frame update
    void Start()
    {
        skillScroll.GetComponent<Image>();
        skillScroll.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (skillScroll.enabled == false)
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                skillScroll.enabled = true;
            }
        }
        else if (skillScroll.enabled == true)
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                skillScroll.enabled = false;
            }
        }
        }
        
    }

