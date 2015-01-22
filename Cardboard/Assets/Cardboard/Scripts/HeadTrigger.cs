using UnityEngine;
using System.Collections;

public class HeadTrigger : MonoBehaviour {

	void OnTriggerEnter (Collider other) {
		Debug.Log ("trigger");
		Application.LoadLevel ("Menu");
	}
}
