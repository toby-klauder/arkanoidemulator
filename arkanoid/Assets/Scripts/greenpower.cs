using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenpower : MonoBehaviour
{
    public static bool stuck;
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
        if (collision.gameObject.tag == "player")
        {
            stuck = true;
            bluepowerup.extended = false;
            redpower.enablefire = false; 
        }
    }
}
