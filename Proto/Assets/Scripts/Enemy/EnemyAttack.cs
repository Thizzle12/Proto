using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {

	GameObject player;
	PlayerHealth playerHealth;
	bool playerInRange;
	float timer = 0f;
	public float timeBetweenAttacks = 0.5f;



	void Awake () {
		player = GameObject.FindGameObjectWithTag ("Gamer");
		playerHealth = player.GetComponent <PlayerHealth> ();
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject == player) {
			playerInRange = true;
		}
	}
	
	void OnTriggerExit(Collider other){
		if (other.gameObject == player) {
			playerInRange = false;
		}
		
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer >= timeBetweenAttacks && playerInRange) {
			Attack ();		
		}
	}



	void Attack(){
			timer = 0f;

			playerHealth.TakeDamage();
		Debug.Log (playerHealth.currentHealth);

	}

}
