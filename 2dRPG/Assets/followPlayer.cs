using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{

    // Who we are chasing
    private Transform Player;
    public SpriteRenderer EnemyRenderer;
    public Transform EnemyTransform;
    private Transform playerTransform;

    // how fast we want the enemy to chase
    public float ChaseSpeed = 5f;

    // the range at which it detects Player
    public float Range = 5f;

    // what our current speed is (get only)
    float CurrentSpeed;

    public Animator orcAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {

        var player = GameObject.FindGameObjectWithTag("Player").transform;
        if (Vector3.Distance(transform.position, player.position) <= Range) // check the distance between this game object and Player and continue if it's less than Range
        {
            
            orcAnimator.Play("attack");
            CurrentSpeed = ChaseSpeed * Time.deltaTime; // set the CurrentSpeed to ChaseSpeed and multiply by Time.deltaTime (this prevents it from moving based on FPS)
            transform.position = Vector3.MoveTowards(transform.position, player.position, CurrentSpeed);  // set this game objects position to the Player's position at the speed of CurrentSpeed
            var playerLocation = GameObject.FindGameObjectWithTag("Player").transform;

            float currentTransform = EnemyTransform.position.x;
            float playersTransform = playerLocation.position.x;

            if (currentTransform > playersTransform)
            {
                EnemyRenderer.flipX = true;
            } else
            {
                EnemyRenderer.flipX = false;
            }
            
        } else
        {
            orcAnimator.Play("Idle");
        }
       

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(GameObject.FindGameObjectWithTag("Player"))
        {
            Debug.Log("Triggered");
            orcAnimator.Play("attack");
        }
    }
}
