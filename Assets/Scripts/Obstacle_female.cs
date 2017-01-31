using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_female : MonoBehaviour {

    GameObject player;
    PlayerController pc;

    private void Start()
    {
        pc = FindObjectOfType<PlayerController>();
        player = GameObject.Find("Player");
    }

    private void Update()
    {
        var distance = Vector3.Distance(gameObject.transform.position, player.transform.position);
        
        if(distance < 3)
        {
            pc.isControl = false;
        }
    }

}
