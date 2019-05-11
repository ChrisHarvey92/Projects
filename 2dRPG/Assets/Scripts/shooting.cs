using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shooting : MonoBehaviour
{

    public GameObject shootPointLeft;
    public GameObject shootPointRight;
    public SpriteRenderer playerFlip;
    private GameObject chosenSkillPrefab;
    public Transform firePointLeft;
    public Transform firePointRight;
    private Button skill1, skill2, skill3, skill4, skill5, skill6, skill7, skill8;
    public float spellDelay = 2.0f;
    private float timeStamp;
    private int numberActive;


    // Start is called before the first frame update
    void Start()
    {
        shootPointLeft.GetComponent<GameObject>();
        shootPointRight.GetComponent<GameObject>();
        playerFlip.GetComponent<SpriteRenderer>();
        numberActive = 1;
        findButtonIcon();


    }

    // Update is called once per frame
    void Update()

    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            numberActive = 1;
            findButtonIcon();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            numberActive = 2;
            findButtonIcon();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            numberActive = 3;
           // findButtonIcon();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            numberActive = 4;
            //findButtonIcon();
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            numberActive = 5;
          //  findButtonIcon();
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            numberActive = 6;
           // findButtonIcon();
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            numberActive = 7;
            //findButtonIcon();
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            numberActive = 8;
            //findButtonIcon();
        }



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

    

    void findButtonIcon()
    {
        if (numberActive == 1)
        {
            Debug.Log("Finding button icon");
            var iconName = GameObject.FindGameObjectWithTag("skill1");
            var displayName = iconName.GetComponent<Image>().sprite.name;
            Debug.Log("Sprite name: " + displayName);
            if(displayName == ("fireBolt"))
            {
                Debug.Log("fireBolt isTrue");
                var fireBoltPrefab = GameObject.FindGameObjectWithTag("fireBall1");
                chosenSkillPrefab = fireBoltPrefab;
            }
            
        }
        if (numberActive == 2)
        {
            var iconName = GameObject.FindGameObjectWithTag("skill2");
            var displayName = iconName.GetComponent<Image>().sprite.name;
            if (displayName == ("voidBall"))
            {
                Debug.Log("voidBall isTrue");
                var voidBallPrefab = GameObject.FindGameObjectWithTag("voidBall");
                chosenSkillPrefab = voidBallPrefab;
            }
        }
    }

    void castSpellRight()
    {

        Instantiate(chosenSkillPrefab, firePointLeft.position, firePointLeft.rotation);
        Debug.Log("skill: " + chosenSkillPrefab);
    }

    void castSpellLeft()
    {
        Instantiate(chosenSkillPrefab, firePointRight.position, firePointRight.rotation);
    }
}
