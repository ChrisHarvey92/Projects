using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{

    public Vector2 movementDirection;
    public float movementSpeed;

    public float MOVEMENT_BASE_SPEED = 1.0f;

    public Rigidbody2D rb;

    private GameObject playerGO;
    private SpriteRenderer playerSR;
    private Animator wizAnim;

    // Start is called before the first frame update
    void Awake()
    {
        playerGO = GameObject.FindGameObjectWithTag("Player");
        playerSR = playerGO.GetComponent<SpriteRenderer>();
        playerSR.flipX = false;
        wizAnim = playerGO.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
        Move();
        FlipSprite();
    }

    private void Move()
    {
        rb.velocity = movementDirection * movementSpeed * MOVEMENT_BASE_SPEED;
    }

    private void ProcessInputs()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        movementSpeed = Mathf.Clamp(movementDirection.magnitude, 0.0f, 1.0f);
        movementDirection.Normalize();
    }

    private void FlipSprite()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            playerSR.flipX = true;
            wizAnim.Play("Wizard_Run");
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            playerSR.flipX = false;
            wizAnim.Play("Wizard_Run");
        }

        if (Input.GetMouseButtonDown(0))
        {
            wizAnim.Play("Wizard_Attack");
        }

        if (Input.anyKey == false)
        {
            wizAnim.Play("Wizard_Idle");
        }
    }
}
