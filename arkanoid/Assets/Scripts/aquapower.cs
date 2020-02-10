using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aquapower : MonoBehaviour
{
    public GameObject ball;

    GameObject OriginalBall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            redpower.enablefire = false;
            greenpower.stuck = false;
            bluepowerup.extended = false; 
            OriginalBall = GameObject.FindObjectOfType<ball>().gameObject;
            GameObject ballone = Instantiate(ball, OriginalBall.transform.position, Quaternion.identity);
            GameObject balltwo = Instantiate(ball, OriginalBall.transform.position, Quaternion.identity);
            Vector3 ballcurrent = ball.GetComponent<Rigidbody2D>().velocity;
            balltwo.GetComponent<Rigidbody2D>().velocity = Quaternion.Euler(0, 0, 30) * ballcurrent;
            ballone.GetComponent<Rigidbody2D>().velocity = Quaternion.Euler(0, 0, -30) * ballcurrent;
        }
    }
}

