using UnityEngine;
using System.Collections;

public class RayFromCamera : MonoBehaviour {
	private CardboardHead head;
	// Use this for initialization
	int level = 0;
	void Start () {
	head = Camera.main.GetComponent<StereoController>().Head;
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		bool isLookedAt = GetComponent<Collider>().Raycast(head.Gaze, out hit, Mathf.Infinity);
		GetComponent<Renderer>().material.color = isLookedAt ? Color.green : Color.white;
		if (Cardboard.SDK.CardboardTriggered && isLookedAt) {

			if(hit.collider.tag == "PlayAgain"){
				Application.LoadLevel ("DemoScene");
			}
			else if(hit.collider.tag == "Quit"){
				Application.Quit();
			}
			else if(hit.collider.tag == "Difficulty") {
				Application.LoadLevel ("Difficulty");
				level = Application.loadedLevel;

			}
			else if(hit.collider.tag == "Hard") {
				RandomGenerator.Difficulty = 2;
				Application.LoadLevel (level);

			}
			else if(hit.collider.tag == "Normal") {
				RandomGenerator.Difficulty = 1;
				Application.LoadLevel (level);
			}
			else if(hit.collider.tag == "Easy") { 
				RandomGenerator.Difficulty = 0;
				Application.LoadLevel (level);
			}

		}
	}
}
