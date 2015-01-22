using UnityEngine;
using System.Collections;

public class DisplayHighscore : MonoBehaviour {

	// Use this for initialization
	int highscore = 0;
	void Awake () {
		storeHighscore (CalculateScore.score);
		TextMesh tm = gameObject.GetComponent<TextMesh>();
		tm.text = "Highscore:" + highscore;
	}
	void storeHighscore(int newHighscore) {
		int oldHighscore = PlayerPrefs.GetInt ("highscore", 0);
		if (newHighscore > oldHighscore)
			PlayerPrefs.SetInt ("highscore", newHighscore);
		highscore = PlayerPrefs.GetInt ("highscore", 0);
		
	}

}
