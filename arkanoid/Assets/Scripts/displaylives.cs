﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class displaylives : MonoBehaviour
{
    public GameObject image;
    public int displaythreshold; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (displaythreshold <= gamemanager.lives)
        {
            print("test image set: " + gamemanager.lives.ToString()); 
            image.SetActive(true);
        }
        else {
            image.SetActive(false); 
        }
    }

    
}
