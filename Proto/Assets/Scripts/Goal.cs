using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

	GameObject player;
	bool gameWon = false;
	// Use this for initialization
	void Awake () {
		player = GameObject.FindGameObjectWithTag("Gamer");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject == player){
			Debug.Log ("Game won");
			gameWon = true;
		}
	}
}
