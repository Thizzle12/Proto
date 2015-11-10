using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
	public PlayerHealth playerHealth;
	public GameObject player;
	
	private bool gameover = false;
	public int score = 1000;
	//	private int time;
	private bool done = false;
	public static int frames = 0;
	public static int frames2 = 0;
	public bool dead = false;
	public int updateSpeed = 2;
	Text text;
	
	
	void Awake ()
	{
		text = GetComponent <Text> ();
		player = GameObject.FindGameObjectWithTag ("Gamer");
		playerHealth = player.GetComponent<PlayerHealth> ();
	}
	
	void Update ()
	{
		if (score > 0 && playerHealth.currentHealth > 0 && !dead) {
			Time.timeScale = 1.0f;
			frames = Time.frameCount;
			if ((frames % updateSpeed) == 0 && !done) {
				score--;
				text.text = "Score: " + (score);
				done = true;
			} else if (!((frames % updateSpeed) == 0)) {
				done = false;
			}
		} else if (!dead) {
			frames2 = Time.frameCount;
			dead = true;
		} else{
			text.color = Color.red;
			text.fontSize = 80;
			text.alignment = TextAnchor.LowerCenter;
			
			text.text = "Game Over!";
			Time.timeScale = 0.4f;
			
			if(frames2 + 300 <= Time.frameCount){
				dead = false;
				Die ();
				
			}
		}
	}
	public void Die(){
		Application.LoadLevel(Application.loadedLevel);
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
