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
    public GameObject greenpowerpellet;
    public GameObject thisbrick;
    public GameObject[] balls;
    public int poweruptospawn;
    public int powerupchance;
    public int points;
    public bool powerupsenabled; 
    // Start is called before the first frame update
    void Start()
    {
        powerupsenabled = true; 
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] balls = GameObject.FindGameObjectsWithTag("ball");
        if (balls.Length > 1) {
            powerupsenabled = false;
            greenpower.stuck = false; 
            bluepowerup.extended = false; 
            print("disabled powerups, number of balls found: " + balls.Length.ToString()); 
        }
        if (balls.Length == 1) {
            powerupsenabled = true; 
        }
        poweruptospawn = Random.Range(1, 7);
        powerupchance = 1;  

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        numhits++;
        if ((collision.gameObject.tag == "ball" || collision.gameObject.tag == "bullet") && numhits == hitstobreak)
        {
            
            gamemanager.totalpoints += points;
            if (powerupchance == 1 && powerupsenabled)
            {
                if (poweruptospawn == 1)
                {
                    Instantiate(orangepower, thisbrick.transform.position, transform.rotation);
                }
                else if (poweruptospawn == 2)
                {
                    Instantiate(bluepower, thisbrick.transform.position, transform.rotation);
                }
                else if (poweruptospawn == 3)
                {
                    Instantiate(greypower, thisbrick.transform.position, transform.rotation);
                }
                else if (poweruptospawn == 4)
                {
                    Instantiate(aquapower, thisbrick.transform.position, transform.rotation);
                }
                else if (poweruptospawn == 5)
                {
                   // Instantiate(pinkpower, thisbrick.transform.position, transform.rotation);
                }
                else if (poweruptospawn == 6)
                {
                    Instantiate(redpower, thisbrick.transform.position, transform.rotation);
                }
                else if (poweruptospawn == 7)
                {
                    Instantiate(greenpowerpellet, thisbrick.transform.position, transform.rotation);
                }
                
            }
        }
        Destroy(gameObject);
    }
}
