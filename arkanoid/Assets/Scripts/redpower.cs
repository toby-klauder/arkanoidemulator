using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redpower : MonoBehaviour
{
    public static bool enablefire = true; 
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
        //change sprite/animation
        if (collision.gameObject.tag == "player")
        {
            greenpower.stuck = false;
            bluepowerup.extended = false; 
            enablefire = true;
        }
    }
}
