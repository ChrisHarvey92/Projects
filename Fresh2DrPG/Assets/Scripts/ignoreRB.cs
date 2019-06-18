using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ignoreRB : MonoBehaviour
{

    private Rigidbody2D rb;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Exited collision!");
        rb.velocity = new Vector3(0, 0, 0);
    }


}
