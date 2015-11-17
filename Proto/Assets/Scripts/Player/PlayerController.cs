using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


	public float speed = 10.0f;
	float tempSpeed;
	float jump = 0f;
	public float jumpHeight = 7f;
	public bool isGrounded = true;
	private bool doubleJump = false;
	Rigidbody playerRigidbody;




	void Awake(){
		playerRigidbody = GetComponent<Rigidbody> ();


	}


	void Update(){




		if (Input.GetKeyDown (KeyCode.Space) && isGrounded) {
			playerRigidbody.AddForce (10.0f * gameObject.transform.forward + new Vector3 (0, 7, 0), ForceMode.VelocityChange);


		}


	}


	void FixedUpdate(){
		Vector3 vector3Move = new Vector3 (Input.GetAxis ("Horizontal"), 0, 0);
		transform.Translate (vector3Move * 10 * Time.deltaTime, Space.World);
		
		if (this.playerRigidbody) {
			playerRigidbody.freezeRotation = true;
		}
	}


	
}