using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spell : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;
    public GameObject fireballExplosion;
    private enemyHealth enemyhealth;
    private GameObject orcEnemy;
    public static string spellHit;
    private Collider2D collider;
    

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.name == "firebolt(Clone)")
        {
            Destroy(this.gameObject);
            Instantiate(fireballExplosion, transform.position, transform.rotation);
        }
    }
}
