using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bluepowerup : MonoBehaviour
{
    GameObject player;
    GameObject playerpicture;
    SpriteRenderer render;
    public static bool extended; 
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindObjectOfType<playerController>().gameObject;
        playerpicture = GameObject.FindObjectOfType<forcecollider>().gameObject;
        render = playerpicture.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player") {
            print("should extend"); 
            player.transform.localScale = new Vector3(2, 0.4f, 1);
            render.size = new Vector2(3.74f, 0.4f); 
        }
    }
}
