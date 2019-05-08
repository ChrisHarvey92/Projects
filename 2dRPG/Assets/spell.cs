using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spell : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;
    public GameObject fireballExplosion;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        Destroy(gameObject);
        Instantiate(fireballExplosion, transform.position, transform.rotation);
    }

    
    


}
