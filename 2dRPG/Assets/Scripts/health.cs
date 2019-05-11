using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{

    Image healthBar;
    float maxHealth = 100f;
    public static float totalHealth;
    Text healthAmount;


    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Image>();
        healthAmount = GetComponent<Text>();
        totalHealth = maxHealth;
        
    }

    // Update is called once per frame
    void Update()
    {
        var healthNumber = totalHealth / maxHealth;
        healthBar.fillAmount = healthNumber;
        healthAmount.text = healthNumber.ToString();
    }
}
