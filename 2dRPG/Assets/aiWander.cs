using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aiWander : MonoBehaviour
{

    public float accelerationTime = 1.5f;
    public float speed = 4f;
    private Vector2 movement;
    private float timeLeft;
    public Rigidbody2D rb;
    public Animator orcAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            timeLeft += accelerationTime;
        }

    }

    void FixedUpdate()
    {
        rb.AddForce(movement * speed);
    }

}
