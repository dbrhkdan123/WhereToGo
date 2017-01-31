using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 5;
    public bool isControl = true;

    Rigidbody rb;

	void Update () {

        rb = GetComponent<Rigidbody>();

        if (isControl)
        {
            PlayerMove();
        }

	}

    void PlayerMove()
    {
        float hor = Input.GetAxis("Horizontal");
        hor = Random.Range(hor - 2, hor + 2) * 5;
        float ver = Input.GetAxis("Vertical");
        ver = Random.Range(ver - 2, ver + 2) * 5;
     
        rb.velocity = new Vector3(hor, 0, ver);

    }
}