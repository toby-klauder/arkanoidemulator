using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    GameObject player;
    GameObject playerpicture;
    SpriteRenderer Render; 
    public GameObject bullet; 
    public static int lives;
    public Sprite laservaus;
    public Sprite normalvaus; 
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindObjectOfType<playerController>().gameObject;
        playerpicture = GameObject.FindObjectOfType<forcecollider>().gameObject;
        Render = playerpicture.GetComponent<SpriteRenderer>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A) && transform.position.x > -6.5 && !gamemanager.lockmovement) {
            Vector3 position = this.transform.position;
            position.x -= (float)0.25;
            this.transform.position = position; 
        }
        if (Input.GetKey(KeyCode.D) && transform.position.x < 6.5 && !gamemanager.lockmovement) {
            Vector3 position = this.transform.position;
            position.x += (float)0.25;
            this.transform.position = position; 
        }
    }
    void Update()
    {
        if (redpower.enablefire) {
            Render.sprite = laservaus;
        }
        if (!redpower.enablefire) {
            Render.sprite = normalvaus; 
        }
        if (Input.GetKeyDown(KeyCode.Space) && redpower.enablefire) {
            GameObject bulletone = Instantiate(bullet, this.transform.position, transform.rotation);
           // bulletone.transform.eulerAngles = Vector3.forward * 90;
            bulletone.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 20, 0); 
        }
        if (bluepowerup.extended == true)
        {
            player.transform.localScale = new Vector3(2, 0.4f, 1);
            Render.size = new Vector2(3.74f, 0.4f);
        }
        else if (bluepowerup.extended == false) {
            player.transform.localScale = new Vector3(1, 0.4f, 1);
            Render.size = new Vector2(2.44f, 0.4f); 
        }
    }


}
