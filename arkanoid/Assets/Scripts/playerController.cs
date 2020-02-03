using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public static int lives; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A) && transform.position.x > -6.5) {
            Vector3 position = this.transform.position;
            position.x -= (float)0.1;
            this.transform.position = position; 
        }
        if (Input.GetKey(KeyCode.D) && transform.position.x < 7) {
            Vector3 position = this.transform.position;
            position.x += (float)0.1;
            this.transform.position = position; 
        }
    }

  
}
