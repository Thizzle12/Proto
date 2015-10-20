using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	Rigidbody enemyRigidBody;
	Vector3 movement;
	public float speed = 3f;
	float start;
	bool dir = false;
	public float distance = 3f;
	// Use this for initialization
	void Awake () {
		enemyRigidBody = GetComponent<Rigidbody> ();
		start = enemyRigidBody.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		if (enemyRigidBody.transform.position.x <= start + distance && dir == false) {
			movement.Set (10f, 0f, 0f);

		} else if (enemyRigidBody.transform.position.x >= start + distance && dir == false) {
			dir = true;
		} else if (enemyRigidBody.transform.position.x >= start - distance && dir == true) {
			movement.Set (-10f, 0f, 0f);
		}
		else if (enemyRigidBody.transform.position.x <= start - distance && dir == true) {
				dir = false;

		}
		movement = movement.normalized * speed * Time.deltaTime;
		enemyRigidBody.MovePosition (transform.position + movement);
	 
	}
}
