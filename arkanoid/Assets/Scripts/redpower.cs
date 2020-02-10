using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redpower : MonoBehaviour
{
    public GameObject player; 
    public static bool enablefire;
    public SpriteRenderer playerrender;
    public Sprite laservaus; 
    // Start is called before the first frame update
    void Start()
    {
        playerrender = player.GetComponent<SpriteRenderer>(); 
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
            playerrender.sprite = laservaus; 

        }
    }
}
