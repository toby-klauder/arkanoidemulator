using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class gamemanager : MonoBehaviour
{
    public static int totalpoints;
    public Text pointtext; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pointtext.text = totalpoints.ToString(); 
    }


}
