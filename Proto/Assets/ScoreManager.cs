using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
	public static int score = 1000;
//	private int time;
	private bool done = false;
	public int frames = 0;
	Text text;
	
	
	void Awake ()
	{
		text = GetComponent <Text> ();
	}

	void Update ()
	{
		if (!(score <= 0)) {
			frames = Time.frameCount;
			if ((frames % 2) == 0 && !done) {
				score--;
				text.text = "Score: " + (score);
				done = true;
			} else if (!((frames % 2) == 0)) {
				done = false;
			}
		} else {
			text.text = "Game over!";
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
}
