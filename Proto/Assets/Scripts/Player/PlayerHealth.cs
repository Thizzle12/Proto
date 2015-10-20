using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public int startHealth = 3;
	public int currentHealth;
	public Image heart1;
	public Image heart2;
	public Image heart3;


	bool isDead;
	bool damaged;
	PlayerMovement pMove;
	// Use this for initialization
	void Start () {
		pMove = GetComponent<PlayerMovement> ();
		currentHealth = startHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if (damaged) {
			if (currentHealth == 2) {
				heart3.enabled = false;
			}
			if (currentHealth == 1) {
				heart2.enabled = false;
			}
			if (currentHealth == 0) {
				heart1.enabled = false;
				Debug.Log("Player is dead!!");
			}
		} else {
			damaged = false;
		}


	
	}

	public void TakeDamage(){
		damaged = true;

		currentHealth -= 1;
		Debug.Log (currentHealth);




	}
}
