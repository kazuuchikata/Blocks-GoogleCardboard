using UnityEngine;
using System.Collections;

public class CalculateScore : MonoBehaviour {

	// Use this for initialization
	public static int score = 1;
	float time = 0;

	void Awake() {
		DontDestroyOnLoad (transform.gameObject);
		score = 1;
		}
	void Update () {
		time += Time.deltaTime;
		totalScore();
	}
	public void totalScore() {
		if (time == 0)
			score = 0;
		else
			score = Mathf.RoundToInt ((time) * 789);
	}
}
