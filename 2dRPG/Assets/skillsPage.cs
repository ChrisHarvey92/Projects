using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skillsPage : MonoBehaviour {

    public Image ancientScroll;
    public Canvas skillsCanvas;

    // Start is called before the first frame update
    void Awake()
    {
        ancientScroll.GetComponent<Image>();
        ancientScroll.enabled = false;

        skillsCanvas.GetComponent<Canvas>();
        skillsCanvas.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (ancientScroll.enabled == true)
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                ancientScroll.enabled = false;
                skillsCanvas.enabled = false;

            }
        }

        else if (ancientScroll.enabled == false)
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                ancientScroll.enabled = true;
                skillsCanvas.enabled = true;
            }
        }
        
        
    }
}
