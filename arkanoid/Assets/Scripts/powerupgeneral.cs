using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupgeneral : MonoBehaviour
{
    public AudioSource source; 
    public AudioClip clip; 
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player") {
            gamemanager.totalpoints += 1000;
            source.PlayOneShot(clip);
            print("play clip");
            Destroy(gameObject); 
        }

        if (collision.gameObject.tag == "destroyobj") {
            Destroy(gameObject); 
        }
    }
}
