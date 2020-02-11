using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bluepowerup : MonoBehaviour
{
    public static bool extended; 
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
        if (collision.gameObject.tag == "player")
        {
            extended = true; 
            redpower.enablefire = false;
            greenpower.stuck = false;
        }
    }
}
