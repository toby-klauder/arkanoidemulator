using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class destroyoncollide : MonoBehaviour
{
    public int hitstobreak; 
    public int numhits; 
    public Random rand = new Random(); 
    public int points;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision) {
        numhits++; 
        if (collision.gameObject.tag == "ball" && numhits == hitstobreak) {
            print("test");
            gamemanager.totalpoints += points;
            Destroy(gameObject); 
        }
    }
}
