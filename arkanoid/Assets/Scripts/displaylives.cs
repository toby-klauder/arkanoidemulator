using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class displaylives : MonoBehaviour
{
    public GameObject image;
    Image myImage; 
    public int displaythreshold; 
    // Start is called before the first frame update
    void Start()
    {
        myImage = image.GetComponent<Image>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (displaythreshold <= gamemanager.lives)
        {
            myImage.enabled = true; 
        }
        else if (displaythreshold > gamemanager.lives) {
            myImage.enabled = false; 
        }
    }

    
}
