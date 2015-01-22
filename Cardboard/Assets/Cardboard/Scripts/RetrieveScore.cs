using UnityEngine;
using System.Collections;

public class RetrieveScore : MonoBehaviour {

	// Use this for initialization
	
	void Start () {
		TextMesh tm = gameObject.GetComponent<TextMesh>();
		tm.text = "Score:" + CalculateScore.score;

	}

}
