using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 5;
	public bool isControl = true;
	private Animator ani;
	Rigidbody rb;

	float currentTime = 0;
	float coolTime = 1;
	float horRandom;
	float verRandom;

	void Start () {
		ani = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody>();
	}
	void Update () {

		currentTime += Time.deltaTime;

		if (currentTime > coolTime) {
			horRandom = Random.Range (-1f, 1f);
			verRandom = Random.Range (-1f, 1f);

			currentTime = 0;

		}


		if (isControl)
		{
			PlayerMove();
		}

	}

	void PlayerMove()
	{
		float hor = Input.GetAxis("Horizontal");
		//Debug.Log(hor);
		hor = (hor + horRandom) * 30 * Time.deltaTime;
		float ver = Input.GetAxis("Vertical");
		ver = (ver + verRandom) * 30 * Time.deltaTime;

		var moving = new Vector3(hor, 0, ver);
		rb.velocity = moving;

		float hor2 = Input.GetAxis("Horizontal");
		float ver2 = Input.GetAxis ("Vertical");

		var looking = new Vector3 (hor2, 0, ver2);

		var lookPos = transform.position + looking;
		transform.LookAt (lookPos);

	}
}