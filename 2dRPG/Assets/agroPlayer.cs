using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agroPlayer : MonoBehaviour
{
    
    public float enemySpeed = 1.0f;
    public aiWander wanderScript;
    public Transform enemyTransform;

    
    

    void OnTriggerEnter2D(Collider2D collision)
    {
        var playerIdentify = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        var enemyIdentify = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();

        var speed = enemySpeed * Time.deltaTime;
        

        if (collision.gameObject.tag == "Player")
        {
            wanderScript.enabled = false;
            Debug.Log("Triggered");
            enemyTransform.transform.position = Vector2.MoveTowards(enemyTransform.position, playerIdentify.position, speed * Time.deltaTime);
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {

        var playerIdentify = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        var enemyIdentify = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
        var speed = enemySpeed * Time.deltaTime;

        if (collision.gameObject.tag == "Player")
            {

            Debug.Log("Still in trigger");
            enemyTransform.transform.position = Vector2.MoveTowards(enemyTransform.position, playerIdentify.position, speed * Time.deltaTime);
        }
    }

     void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            {
            var playerIdentify = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
            var enemyIdentify = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
            var speed = enemySpeed * Time.deltaTime;
            Debug.Log("Exited trigger");
            enemyTransform.transform.position = Vector2.MoveTowards(enemyTransform.position, playerIdentify.position, speed * Time.deltaTime);
        }
    }
}
