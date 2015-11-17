using UnityEngine;
using System.Collections;

public class BrickFall : MonoBehaviour {
	
	GameObject brick;
	GameObject player;
	
	// Use this for initialization
	void Awake () {
		player = GameObject.FindGameObjectWithTag ("Player");
		brick = GameObject.FindGameObjectWithTag ("Brick");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other){
		if (other.gameObject == player) {
			brick.GetComponent<Rigidbody>().useGravity = true;
			Debug.Log ("Brick falder");
		}
		Debug.Log ("Jeg har trigget");
	}
}
