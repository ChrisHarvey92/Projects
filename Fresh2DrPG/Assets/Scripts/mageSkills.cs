using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mageSkills : MonoBehaviour
{

    private Image fireboltIcon, firewallIcon, voidburstIcon, electricpulseIcon, lightauraIcon, speedauraIcon, powerauraIcon, darkauraIcon, skillBar;
    private GameObject skillScroll;
    private SpriteRenderer scrollRenderer;

    // Start is called before the first frame update
    void Start()
    {
        fireboltIcon = Resources.Load<Image>("Images/firebolt");
        firewallIcon = Resources.Load<Image>("Images/firewall");
        voidburstIcon = Resources.Load<Image>("Images/voidburst");
        electricpulseIcon = Resources.Load<Image>("Images/electricpulse");
        lightauraIcon = Resources.Load<Image>("Images/lightaura");
        speedauraIcon = Resources.Load<Image>("Images/speedaura");
        powerauraIcon = Resources.Load<Image>("Images/poweraura");
        darkauraIcon = Resources.Load<Image>("Images/darkaura");

        skillBar = GetComponent<Image>();
        skillScroll = GameObject.FindGameObjectWithTag("skillScroll");
        scrollRenderer = skillScroll.GetComponent<SpriteRenderer>();
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
