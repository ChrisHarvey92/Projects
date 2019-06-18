using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{

    public int enemyHP;
    private GameObject OrcEnemy;
    private Animator Anim;
    private aiWander aiwander;
    private spell spellScript;
    private spellDmg spellDmgScript;
    public string spellHit;
    private Rigidbody2D rb2d;
  

    private void Awake()
    {
        Anim = this.GetComponent<Animator>();
        aiwander = this.GetComponent<aiWander>();
        spellDmgScript = GameObject.FindGameObjectWithTag("Scripts").GetComponent<spellDmg>();
        rb2d = GetComponent<Rigidbody2D>();
        

        
    }
    

    private void Update()
    {
        if(enemyHP <= 0)
        {
            aiwander.enabled = false;
            Anim.Play("DIE");
            StartCoroutine(DestroyObject());
            this.name = "Dead";
        }
    }

    private IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(1);
        Destroy(GameObject.Find("Dead"));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        switch(collision.gameObject.name)
        {
            case "magePlayer":
                
                break;

            case "firebolt(Clone)":
                enemyHP -= spellDmgScript.fireboltTotalDmg;
                Debug.Log(enemyHP);
                break;

            

            
        }
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log(collision.gameObject.name);

        switch (collision.gameObject.name)
            
        {
            case "voidburst(Clone)":
                InvokeRepeating("voidBurstDmg", 0.5f, 1f);
                Debug.Log(enemyHP);
                break;

            case "earthblast(Clone)":
                InvokeRepeating("earthblastDmg", 1f, 1f);
                break;

            case "arcanewall(Clone)":
                InvokeRepeating("arcanewallDmg", 1f, 2f);
                break;

            case "frostspray(Clone)":
                InvokeRepeating("frostsprayDmg", 1f, 1f);
                break;
        }


}

    private void voidBurstDmg()
    {
        enemyHP -= spellDmgScript.voidburstTotalDmg;
        CancelInvoke();
    }

    private void earthblastDmg()
    {
        enemyHP -= spellDmgScript.earthblastTotalDmg;
        Debug.Log(enemyHP);
        CancelInvoke();
    }

    private void arcanewallDmg()
    {
        enemyHP -= spellDmgScript.arcanewallTotalDmg;
        Debug.Log(enemyHP);
        CancelInvoke();
    }

    private void frostsprayDmg()
    {
        enemyHP -= spellDmgScript.frostsprayTotalDmg;
        Debug.Log(enemyHP);
        CancelInvoke();
    }
}
