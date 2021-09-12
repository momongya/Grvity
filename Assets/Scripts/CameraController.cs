using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<PlayerController>().GameStatus() == true)
        {
            transform.position += transform.right * player.GetComponent<PlayerController>().PlayerSpeed() * Time.deltaTime;
        }
    }
}
