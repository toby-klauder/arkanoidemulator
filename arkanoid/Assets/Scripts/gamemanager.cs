using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class gamemanager : MonoBehaviour
{
    public static int totalpoints;
    public Text pointtext;
    public static int lives = 2;
    public GameObject[] bricks;
    public GameObject[] balls; 
    public static bool lockmovement;
    public GameObject ballgame;
    public Vector3 position;
    public Text gameovertext; 
    // Start is called before the first frame update
    void Start()
    {
        bricks = GameObject.FindGameObjectsWithTag("brick");
        balls = GameObject.FindGameObjectsWithTag("ball");
        position = new Vector3(0, -6.48f, 0);
        gameovertext.enabled = false; 
    }

    // Update is called once per frame
    void Update()
    {
        bricks = GameObject.FindGameObjectsWithTag("brick");
        balls = GameObject.FindGameObjectsWithTag("ball");
        pointtext.text = totalpoints.ToString();

        if (bricks.Length == 0) {
            redpower.enablefire = false;
            greenpower.stuck = false;
            bluepowerup.extended = false;
            lockmovement = true;
            print("win condition achieved"); 
        }

        if (lives == 0) {
            redpower.enablefire = false;
            greenpower.stuck = false;
            bluepowerup.extended = false;
            lockmovement = true;
            gameovertext.enabled = true; 
            print("loss condition achieved"); 
        }

        if (balls.Length == 0) {
            lives--;
            Vector3 vec = new Vector3(0, -1f, 0);
            int rand1 = Random.Range(-3, 5);
            int rand2 = Random.Range(-5, -1);
            GameObject ballone = Instantiate(ballgame, vec, transform.rotation);
            ballone.GetComponent<Rigidbody2D>().velocity = new Vector2(rand1, rand2);
            ball.speed = ball.ballstartspeed; 
            print(greenpower.stuck.ToString()); 
        }


    }


}
