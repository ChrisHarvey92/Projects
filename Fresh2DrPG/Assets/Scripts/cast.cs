using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cast : MonoBehaviour
{
    public GameObject leftTrigger, rightTrigger;
    private SpriteRenderer isFlipped;
    private int activeButton;
    private GameObject skill1, skill2, skill3, skill4, skill5, skill6, skill7, skill8, instanObj, aura, characterRenderer;
    private Image skill1Img, skill2Img, skill3Img, skill4Img, skill5Img, skill6Img, skill7Img, skill8Img;
    private String userInput;
    private int userInputInt;
    private string activeSkill;
    private GameObject spellToCast, loadPrefab, tempObj;
    private Transform rtTransform;
    private Transform ltTransform;
    public Canvas tileCanvas;
    private IEnumerator coroutine;
    private Transform keepTransform;
    private Vector3 unstablePos;

    void Awake()
    {
        leftTrigger.GetComponent<GameObject>();
        rightTrigger.GetComponent<GameObject>();
        characterRenderer = GameObject.FindGameObjectWithTag("Player");
        isFlipped = characterRenderer.GetComponent<SpriteRenderer>();
        skill1 = GameObject.FindGameObjectWithTag("S1");
        skill2 = GameObject.FindGameObjectWithTag("S2");
        skill3 = GameObject.FindGameObjectWithTag("S3");
        skill4 = GameObject.FindGameObjectWithTag("S4");
        skill5 = GameObject.FindGameObjectWithTag("S5");
        skill6 = GameObject.FindGameObjectWithTag("S6");
        skill7 = GameObject.FindGameObjectWithTag("S7");
        skill8 = GameObject.FindGameObjectWithTag("S8");
        skill1Img = skill1.GetComponent<Image>();
        skill2Img = skill2.GetComponent<Image>();
        skill3Img = skill3.GetComponent<Image>();
        skill4Img = skill4.GetComponent<Image>();
        skill5Img = skill5.GetComponent<Image>();
        skill6Img = skill6.GetComponent<Image>();
        skill7Img = skill7.GetComponent<Image>();
        skill8Img = skill8.GetComponent<Image>();
        rtTransform = rightTrigger.transform;
        ltTransform = leftTrigger.transform;
        activeButton = 1;
        aura = GameObject.Find("aura");
        DontDestroyOnLoad(this);
        






    }

    void Update()
    {
        if (isFlipped.flipX == false)
        {
            rightTrigger.SetActive(true);
            leftTrigger.SetActive(false);
        }
        else
        {
            rightTrigger.SetActive(false);
            leftTrigger.SetActive(true);
        }

        if (GameObject.Find("FireImpactMega(Clone)") != null)
        {
            Destroy(GameObject.Find("FireImpactMega(Clone)"), 2);
        }
        if (GameObject.Find("ArcaneImpactMega(Clone)") != null)
        {
            Destroy(GameObject.Find("ArcaneImpactMega(Clone)"), 2);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Alpha8))
        {

            userInput = Input.inputString;
            switch (userInput)
            {
                case "1":
                    activeButton = 1;
                    getSpell();

                    break;

                case "2":
                    activeButton = 2;
                    getSpell();
                    break;

                case "3":
                    activeButton = 3;
                    getSpell();
                    break;

                case "4":
                    activeButton = 4;
                    getSpell();
                    break;

                case "5":
                    activeButton = 5;
                    getSpell();
                    break;

                case "6":
                    activeButton = 6;
                    getSpell();
                    break;

                case "7":
                    activeButton = 7;
                    getSpell();
                    break;

                case "8":
                    activeButton = 8;
                    getSpell();
                    break;
            }

           


        }

        if (Input.GetMouseButtonDown(0))
        {
            if (loadPrefab != null)
            {

                    switch (activeSkill)
                    {
                        case "firebolt":
                        case "voidburst":
                            if(isFlipped.flipX == false)
                            Instantiate(loadPrefab, rtTransform.position, rtTransform.rotation);
                            else
                            Instantiate(loadPrefab, ltTransform.position, ltTransform.rotation);
                            break;

                       

                        case "earthblast":
                            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                            instanObj = Instantiate(loadPrefab, pos, rtTransform.rotation);
                            Destroy(instanObj, 4);
                            break;

                        case "frostspray":
                            if (isFlipped.flipX == false)
                            {
                            instanObj = Instantiate(loadPrefab, rtTransform.position, Quaternion.Euler(0, 90, 0));
                            //instanObj.transform.parent = GameObject.Find("rightTrigger").transform;
                            Destroy(instanObj, 4);
                            }
                            else
                            {
                            instanObj = Instantiate(loadPrefab, ltTransform.position, Quaternion.Euler(0, -90, 0));
                            //instanObj.transform.parent = GameObject.Find("leftTrigger").transform;
                            Destroy(instanObj, 4);
                            }
                            break;

                        case "lightshield":
                        case "speedaura":
                            instanObj = Instantiate(loadPrefab, aura.transform.position, aura.transform.rotation);
                            instanObj.transform.parent = GameObject.Find("magePlayer").transform;
                            Destroy(instanObj, 4);
                            break;

                    case "arcanewall":
                        if (isFlipped.flipX == false)
                        {
                           instanObj = Instantiate(loadPrefab, rtTransform.position, Quaternion.Euler(180, 0, 90));
                            Destroy(instanObj, 4);
                            
                        }
                        else
                        {
                            instanObj = Instantiate(loadPrefab, ltTransform.position, Quaternion.Euler(180, 0, 90));
                            Destroy(instanObj, 4);
                        }
                        break;

                    case "unstableburst":
                        if (isFlipped.flipX == false)
                        {
                            instanObj = Instantiate(loadPrefab, rtTransform.position, Quaternion.Euler(0, 0, 0));
                            unstablePos = GameObject.Find("unstableburst(Clone)").transform.position;
                            Destroy(instanObj, 4);
                            StartCoroutine(UnstableBurst());

                        }
                        else
                        {
                            instanObj = Instantiate(loadPrefab, ltTransform.position, Quaternion.Euler(0, 0, 0));
                            unstablePos = GameObject.Find("unstableburst(Clone)").transform.position;
                            Destroy(instanObj, 4);
                            StartCoroutine(UnstableBurst());
                        }
                        break;

                    



                    }
                }
            }



        
    }

    private IEnumerator UnstableBurst()
    {
        tempObj = Resources.Load("mageSkill/burst") as GameObject;
        yield return new WaitForSeconds(5);
        
        
        instanObj = Instantiate(tempObj, unstablePos, Quaternion.Euler(0, 0, 0));
        Destroy(instanObj, 5);
        activeButton = 0;

    }

    private void getSpell()
    {
        switch(activeButton)
        {
            case 0:
                Debug.Log("Please select a skill!");
                break;

            case 1:
                activeSkill = skill1Img.sprite.name;
                loadPrefab = Resources.Load("mageSkill/" + activeSkill) as GameObject;
                break;

            case 2:
                activeSkill = skill2Img.sprite.name;
                Debug.Log("Active skill: " + activeSkill);
                loadPrefab = Resources.Load("mageSkill/" + activeSkill) as GameObject;
                break;

            case 3:
                activeSkill = skill3Img.sprite.name;
                loadPrefab = Resources.Load("mageSkill/" + activeSkill) as GameObject;
                break;

            case 4:
                activeSkill = skill4Img.sprite.name;
                loadPrefab = Resources.Load("mageSkill/" + activeSkill) as GameObject;
                break;

            case 5:
                activeSkill = skill5Img.sprite.name;
                loadPrefab = Resources.Load("mageSkill/" + activeSkill) as GameObject;
                break;

            case 6:
                activeSkill = skill6Img.sprite.name;
                loadPrefab = Resources.Load("mageSkill/" + activeSkill) as GameObject;
                break;

            case 7:
                activeSkill = skill7Img.sprite.name;
                loadPrefab = Resources.Load("mageSkill/" + activeSkill) as GameObject;
                break;

            case 8:
                activeSkill = skill8Img.sprite.name;
                loadPrefab = Resources.Load("mageSkill/" + activeSkill) as GameObject;
                break;
        }
    }
}
