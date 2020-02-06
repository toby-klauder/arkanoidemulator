using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public GameObject bullet; 
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
            position.x -= (float)0.25;
            this.transform.position = position; 
        }
        if (Input.GetKey(KeyCode.D) && transform.position.x < 6.5) {
            Vector3 position = this.transform.position;
            position.x += (float)0.25;
            this.transform.position = position; 
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && redpower.enablefire) {
            GameObject bulletone = Instantiate(bullet, this.transform.position, transform.rotation);
           // bulletone.transform.eulerAngles = Vector3.forward * 90;
            bulletone.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 20, 0); 
        }  
    }


}
