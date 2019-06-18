using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GVScript : MonoBehaviour
{
    Transform playerLoc;

    // Start is called before the first frame update
    void Start()
    {
        playerLoc = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        movePlayer();
    }

    private void movePlayer()
    {
        playerLoc.transform.position = new Vector3(83, 14, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
