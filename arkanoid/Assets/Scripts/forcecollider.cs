using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forcecollider : MonoBehaviour
{
    public GameObject player;
    public GameObject playerpic; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerpic.transform.position = player.transform.position; 
    }
}
