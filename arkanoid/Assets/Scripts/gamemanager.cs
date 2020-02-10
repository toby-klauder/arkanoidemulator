using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class gamemanager : MonoBehaviour
{
    public static int totalpoints;
    public Text pointtext;
    public static int lives = 2;
    public GameObject[] bricks;
    public static bool lockmovement;
    // Start is called before the first frame update
    void Start()
    {
        bricks = GameObject.FindGameObjectsWithTag("brick"); 
    }

    // Update is called once per frame
    void Update()
    {
        pointtext.text = totalpoints.ToString();

        if (bricks.Length == 0) {
            redpower.enablefire = false;
            greenpower.stuck = false;
            bluepowerup.extended = false;
            lockmovement = true;
            print("win condition achieved"); 
        }

    }


}
