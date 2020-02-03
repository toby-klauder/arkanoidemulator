using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class destroyoncollide : MonoBehaviour
{
    public int hitstobreak; 
    public int numhits;
    public GameObject orangepower;
    public GameObject bluepower;
    public GameObject aquapower;
    public GameObject pinkpower;
    public GameObject greypower;
    public GameObject redpower;
    public GameObject greenpower;
    public GameObject thisbrick; 
    public int poweruptospawn;
    public int powerupchance; 
    public int points;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        poweruptospawn = Random.Range(1, 7); 
        
    }

    void OnCollisionEnter2D(Collision2D collision) {
        numhits++; 
        if (collision.gameObject.tag == "ball" && numhits == hitstobreak) {
            print("test");
            gamemanager.totalpoints += points;
            if (poweruptospawn == 1)
            {
                Instantiate(orangepower);
            }
            else if (poweruptospawn == 2)
            {
                Instantiate(bluepower);
            }
            else if (poweruptospawn == 3)
            {
                Instantiate(greypower);
            }
            else if (poweruptospawn == 4)
            {
                Instantiate(aquapower);
            }
            else if (poweruptospawn == 5)
            {
                Instantiate(pinkpower);
            }
            else if (poweruptospawn == 6)
            {
                Instantiate(redpower);
            }
            else if (poweruptospawn == 7) {
                Instantiate(greenpower); 
            }
            Destroy(gameObject); 
        }
    }
}
