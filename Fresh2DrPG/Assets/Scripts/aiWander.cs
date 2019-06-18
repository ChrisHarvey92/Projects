using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class aiWander : MonoBehaviour
{

    internal Transform thisTransform;

    // The movement speed of the object
    public float moveSpeed = 0.2f;

    // A minimum and maximum time delay for taking a decision, choosing a direction to move in
    public Vector2 decisionTime = new Vector2(1, 4);
    internal float decisionTimeCount = 0;

    // The possible directions that the object can move int, right, left, up, down, and zero for staying in place. I added zero twice to give a bigger chance if it happening than other directions
    internal Vector3[] moveDirections = new Vector3[] { Vector3.right, Vector3.left, Vector3.up, Vector3.down, (Vector3.up + Vector3.left).normalized, (Vector3.up + Vector3.right).normalized, (Vector3.down + Vector3.left).normalized, (Vector3.down + Vector3.right).normalized,  Vector3.zero, Vector3.zero };
    internal int currentMoveDirection;

    private Animator Anim;
    private SpriteRenderer Flip;
    private enemyHealth enemyhealth;

    // Use this for initialization
    void Start()
    {

        Anim = this.GetComponent<Animator>();
        Flip = this.GetComponent<SpriteRenderer>();
        // Cache the transform for quicker access
        thisTransform = this.transform;

        // Set a random time delay for taking a decision ( changing direction, or standing in place for a while )
        decisionTimeCount = Random.Range(decisionTime.x, decisionTime.y);

        // Choose a movement direction, or stay in place
        ChooseMoveDirection();
        enemyhealth = this.GetComponent<enemyHealth>();
    }

    // Update is called once per frame
    void Update()
    {

        var currentPos = this.transform.position;
        
        // Move the object in the chosen direction at the set speed
        thisTransform.position += moveDirections[currentMoveDirection] * Time.deltaTime * moveSpeed;

        if (decisionTimeCount > 0) decisionTimeCount -= Time.deltaTime;
        else
        {
            // Choose a random time delay for taking a decision ( changing direction, or standing in place for a while )
            decisionTimeCount = Random.Range(decisionTime.x, decisionTime.y);

            // Choose a movement direction, or stay in place
            ChooseMoveDirection();
        }

        if(currentMoveDirection == 8 || currentMoveDirection == 9)
        {
            Anim.Play("IDLE");
        } else
        {
            Anim.Play("WALK");
        }

        if(currentMoveDirection == 1 || currentMoveDirection == 4 || currentMoveDirection == 6)
        {
            Flip.flipX = true;
        } else
        {
            Flip.flipX = false;
        }
    }

    void ChooseMoveDirection()
    {
        // Choose whether to move sideways or up/down
        currentMoveDirection = Mathf.FloorToInt(Random.Range(0, moveDirections.Length));
        
        
    }

}
