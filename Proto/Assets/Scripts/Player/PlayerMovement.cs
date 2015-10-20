using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	Vector3 movement;
	public float speed = 5f;
	Rigidbody playerRigidbody;
	bool air = false;
	bool grounded = true;
	float startY;
	public float jumpHeight = 3f;

	// Use this for initialization
	void Awake () {
		playerRigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxisRaw ("Horizontal");
		//float v = Input.GetAxisRaw ("Vertical");

		movement.Set (h, 0f, 0f);

		if (Input.GetKeyDown ("space") && air == false) {
			air = true;
			playerRigidbody.useGravity = false;
			startY = playerRigidbody.transform.position.y;
			speed = speed * 2;
			grounded = false;
		}

		if (playerRigidbody.transform.position.y < startY + jumpHeight && air == true) {
			movement.Set (h, 1f, 0f);
		} else if(playerRigidbody.transform.position.y >= startY + jumpHeight && air == true){
			air = false;
			playerRigidbody.useGravity = true;
			speed = speed / 2;


		}



		movement = movement.normalized * speed * Time.deltaTime;

		playerRigidbody.MovePosition (transform.position + movement);


	}
}
