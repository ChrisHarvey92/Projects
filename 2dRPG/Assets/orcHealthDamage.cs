using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orcHealthDamage : MonoBehaviour
{
    public int Health;
    public int Damage;
    public Animator orcAnimator;
    public followPlayer followScript;

    // Start is called before the first frame update
    void Start()
    {
        Health = 100;
        Damage = 10;
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enemy hit! " + Health);
        Health -= 50;
        if (Health <= 0)
        {
            followScript.enabled = false;
            orcAnimator.Play("orcDie");
            StartCoroutine(destroyOrc());

        }
    }

    IEnumerator destroyOrc()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            Destroy(gameObject);

        }
    }
}
