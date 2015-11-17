using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
	 PlayerHealth playerHealth;
	 GameObject player;

	private bool gameover = false;
	public int score = 1000;
//	private int time;
	private bool done = false;
	public static int frames = 0;
	public int updateSpeed = 2;
	Text text;
	
	
	void Awake ()
	{
		text = GetComponent <Text> ();
		player = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = player.GetComponent<PlayerHealth> ();
	}

	void Update ()
	{
		if (score > 0 && playerHealth.currentHealth > 0) {
			frames = Time.frameCount;
			if ((frames % updateSpeed) == 0 && !done) {
				score--;
				text.text = "Score: " + (score);
				done = true;
			} else if (!((frames % updateSpeed) == 0)) {
					done = false;
				}
		} else{
			text.text = "Game Over!";
		}
	}
	
		//time = (int)Time.time;
		//if ((time % 2) == 0 && !done) {
		//	score--;
		//	text.text = "Score: " + (score);
		//	done = true;
		//} else if(!((time % 2) == 0)) {
		//	done = false;
		//}

}
