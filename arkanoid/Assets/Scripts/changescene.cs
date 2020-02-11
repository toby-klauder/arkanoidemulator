using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class changescene : MonoBehaviour
{
    public string NextScene = "maingame";
    public void changescenes() {
        SceneManager.LoadScene(NextScene); 
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
