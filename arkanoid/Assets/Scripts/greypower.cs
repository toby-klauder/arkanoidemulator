﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greypower : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player") {
            gamemanager.lives = gamemanager.lives + 1;
            redpower.enablefire = false;
            greenpower.stuck = false;
            bluepowerup.extended = false; 
        }
    }
}
