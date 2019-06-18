using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mageSkills : MonoBehaviour
{

    private Image fireboltIcon, firewallIcon, voidburstIcon, electricpulseIcon, lightauraIcon, speedauraIcon, powerauraIcon, darkauraIcon, skillBar;
    private GameObject skillScroll;
    private Canvas scrollRenderer;

    // Start is called before the first frame update
    void Start()
    {

        skillBar = GetComponent<Image>();
        skillScroll = GameObject.FindGameObjectWithTag("skillScroll");
        scrollRenderer = skillScroll.GetComponent<Canvas>();
        DontDestroyOnLoad(GameObject.FindGameObjectWithTag("Player"));
    }

    // Update is called once per frame
    void Update()
    {
        if (scrollRenderer.enabled == false)
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                scrollRenderer.enabled = true;
            }
        } else
        {
            if(Input.GetKeyDown(KeyCode.I))
            {
                scrollRenderer.enabled = false;
            }
        }
        
    }
}
