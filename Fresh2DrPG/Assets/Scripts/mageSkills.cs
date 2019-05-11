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
        fireboltIcon = Resources.Load<Image>("Icons/firebolt");
        firewallIcon = Resources.Load<Image>("Icons/firewall");
        voidburstIcon = Resources.Load<Image>("Icons/voidburst");
        electricpulseIcon = Resources.Load<Image>("Icons/electricpulse");
        lightauraIcon = Resources.Load<Image>("Icons/lightaura");
        speedauraIcon = Resources.Load<Image>("Icons/speedaura");
        powerauraIcon = Resources.Load<Image>("Icons/poweraura");
        darkauraIcon = Resources.Load<Image>("Icons/darkaura");

        skillBar = GetComponent<Image>();
        skillScroll = GameObject.FindGameObjectWithTag("skillScroll");
        scrollRenderer = skillScroll.GetComponent<Canvas>();
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
