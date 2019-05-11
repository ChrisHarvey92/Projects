using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDamage : MonoBehaviour
{

    int Health;
    int powerLevel;
    float SavedTime = 0;
    float DelayTime = 1;
    int amountInCollider;


    // Start is called before the first frame update
    void Start()
    {
        powerLevel = 1;
        Health = (powerLevel * 25) + 100;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Health);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Health -= 10;
            amountInCollider += 1;
            
        }
        
    }

    private void takeDamage()
    {
        Health -= 2 * amountInCollider;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if ((Time.time - SavedTime) > DelayTime)
            {
                SavedTime = Time.time;
                takeDamage();
            }

            }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        amountInCollider = 0;
    }

}

