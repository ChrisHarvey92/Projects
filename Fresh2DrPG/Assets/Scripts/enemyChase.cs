using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyChase : MonoBehaviour
{

    public Collider2D chaseTrigger;
    private Transform player;
    private Transform enemyTransform;
    private float speed = 7f;
    private float moveSpeed;
    private aiWander aiwander;
    private GameObject enemy;
    private Animator thisAnim;
    private SpriteRenderer thisSR;
    private enemyHealth enemyhealth;
    private attackPlayer atkPlayer;
   

    private void Awake()
    {
        chaseTrigger = this.GetComponent<Collider2D>();
        aiwander = GetComponent<aiWander>();
        enemy = this.gameObject;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        moveSpeed = speed * Time.deltaTime;
        enemyTransform = this.transform;
        thisAnim = GetComponent<Animator>();
        thisSR = GetComponent<SpriteRenderer>();
        enemyhealth = GetComponent<enemyHealth>();
        atkPlayer = GetComponent<attackPlayer>();
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name.Equals("magePlayer"))
        {
            Debug.Log("Wooooo!");
            aiwander.enabled = false;
        } 
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("magePlayer") && enemyhealth.enemyHP > 0)
        {
            enemy.transform.position = Vector3.MoveTowards(enemyTransform.position, player.position, moveSpeed);

            if (atkPlayer.isInCollider == false)
            {
                thisAnim.Play("WALK");
            }
            aiwander.enabled = false;
            if (player.transform.position.x > enemyTransform.position.x)
            {
                thisSR.flipX = false;
            }
            else
            {
                thisSR.flipX = true;
            }
        } else
        {
            return;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("magePlayer"))
        {
            aiwander.enabled = true;
        }
    }
}
