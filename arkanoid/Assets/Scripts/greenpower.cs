using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenpower : MonoBehaviour
{
    public GameObject ball;
    public static bool stuck;
    public GameObject player; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.X)) {
            Vector3 relativePoint = player.transform.InverseTransformPoint(ball.transform.position);
            if (relativePoint.x < 0.0)
            {
                ball.GetComponent<Rigidbody2D>().velocity = new Vector3(1, 1, 0);
            }
            else if (relativePoint.x > 0.0) {

                ball.GetComponent<Rigidbody2D>().velocity = new Vector3(-1, -1, 0); 

            }
            stuck = false; 
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gamemanager.totalpoints += 1000; 
        ball.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        stuck = true; 
    }
}
