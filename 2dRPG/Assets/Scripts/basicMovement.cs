using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicMovement : MonoBehaviour
{
    public Animator animator;
    private SpriteRenderer mySpriteRenderer;
    private Animator myMovementAnimator;
    public Rigidbody2D rb;
    public float speed = 10;
    public float animDelay = 2;

    private float timeStamp;

    private void Awake()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        myMovementAnimator = GetComponent<Animator>();
        myMovementAnimator.Play("idle");
    }

    void Update()
    {

        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
        transform.position = transform.position + movement * Time.deltaTime;

        rb.AddForce(movement * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) || (Input.GetKeyDown(KeyCode.DownArrow)) || (Input.GetKeyDown(KeyCode.W)) || (Input.GetKeyDown(KeyCode.S)))
        {
            if (mySpriteRenderer != null)
            {
                myMovementAnimator.Play("run");

            }
        }


        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            mySpriteRenderer.flipX = true;
            myMovementAnimator.Play("run");
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            mySpriteRenderer.flipX = false;
            myMovementAnimator.Play("run");
        }

        if (Input.anyKey == false)
        {
            myMovementAnimator.Play("Idle");
        }

        if (Time.time >= timeStamp &&Input.GetMouseButtonDown(0))
        {
            myMovementAnimator.Play("attack");
            timeStamp = Time.time + animDelay;
        }
        
        
        
        if (Input.GetMouseButtonUp(0))
        {
            myMovementAnimator.enabled = false;
            myMovementAnimator.enabled = true;
            myMovementAnimator.Play("run");
        }
        




    }
}
