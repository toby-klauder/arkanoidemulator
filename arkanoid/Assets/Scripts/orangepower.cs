﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orangepower : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player") {
            ball.speed = ball.speed / 1.25f;
            redpower.enablefire = false;
            bluepowerup.extended = false;
            greenpower.stuck = false; 
        } 
    }
}
