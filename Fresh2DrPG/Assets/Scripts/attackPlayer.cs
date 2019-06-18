using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackPlayer : MonoBehaviour
{

    private Animator anim;
    public bool isInCollider = false;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "magePlayer")
        {
            isInCollider = true;
            Debug.Log("Should play anim now!");
            anim.Play("ATTACK");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "magePlayer")
        {
            isInCollider = false;
            anim.Play("Walk");
        }
    }
}
