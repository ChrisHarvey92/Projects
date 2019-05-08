using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{

    public GameObject shootPointLeft;
    public GameObject shootPointRight;
    public SpriteRenderer playerFlip;
    public GameObject fireBallPrefab;
    public Transform firePointLeft;
    public Transform firePointRight;
    public float spellDelay = 2.0f;
    private float timeStamp;


    // Start is called before the first frame update
    void Start()
    {
        shootPointLeft.GetComponent<GameObject>();
        shootPointRight.GetComponent<GameObject>();
        playerFlip.GetComponent<SpriteRenderer>();


    }

    // Update is called once per frame
    void Update()

    {

      

        if (playerFlip.flipX == true)
        {
            shootPointLeft.SetActive(false);
            shootPointRight.SetActive(true);
        } else { 
            shootPointLeft.SetActive(true);
            shootPointRight.SetActive(false); 
        }
        if (playerFlip.flipX == true) {
            if (Time.time >= timeStamp && Input.GetMouseButtonDown(0))
            {
                 castSpellLeft();
                 timeStamp = Time.time + spellDelay;
            }
        } else if (playerFlip.flipX == false)
        {
            if (Time.time >= timeStamp &&Input.GetMouseButtonDown(0))
            {
                castSpellRight();
                timeStamp = Time.time + spellDelay;

            }
        }

    }

    void castSpellRight()
    {
        Instantiate(fireBallPrefab, firePointLeft.position, firePointLeft.rotation);
    }

    void castSpellLeft()
    {
        Instantiate(fireBallPrefab, firePointRight.position, firePointRight.rotation);
    }
}
