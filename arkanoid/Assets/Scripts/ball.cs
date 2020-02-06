using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public GameObject player; 
    public static float speed = 5f; 
    public Rigidbody2D rb;
    int rand1;
    int rand2;
    public bool touchingplayer;
    public Vector3 offset;
    public bool movewith;
    public float time; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, 0);
        rand1 = Random.Range(-3, 5);
        rand2 = Random.Range(1, 5);
        rb.velocity = new Vector2(rand1, rand2).normalized * speed;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (movewith) {
            rb.transform.position = offset + player.transform.position; 
        }
        rb.velocity = rb.velocity.normalized * speed;
        if ((Input.GetKey(KeyCode.X) && greenpower.stuck && touchingplayer) || time > 10)
        {
            touchingplayer = false;
            movewith = false; 
            Vector3 relativePoint = player.transform.InverseTransformPoint(rb.transform.position);
            if (relativePoint.x > 0.0)
            {
                rb.velocity = new Vector3(1, 1, 0);
            }
            else if (relativePoint.x < 0.0)
            {

                rb.velocity = new Vector3(-1, 1, 0);

            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "player") {
            touchingplayer = true;
            if(greenpower.stuck)
            {
                time = 0;
                print("enter collision"); 
                rb.velocity = Vector3.zero;
                offset = rb.transform.position - player.transform.position;
                movewith = true; 
            }
        }
        if (collision.gameObject.tag == "destroyobj") {
            GameObject[] balls = GameObject.FindGameObjectsWithTag("ball");
            if (balls.Length == 1)
            {
                gamemanager.lives--;
            }
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "wall" || collision.gameObject.tag == "brick") {
            speed += 0.1f; 
        }
    }

   


}
