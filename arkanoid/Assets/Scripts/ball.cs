using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public static float speed = 5f; 
    public Rigidbody2D rb;
    int rand1;
    int rand2; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, 0);
        rand1 = Random.Range(-3, 5);
        rand2 = Random.Range(-3, 5);
        rb.velocity = new Vector2(rand1, rand2).normalized * speed;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = rb.velocity.normalized * speed; 
    }

    void OnCollisionEnter2D(Collision2D collision) {
      
    }
}
