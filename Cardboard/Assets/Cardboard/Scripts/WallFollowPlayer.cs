using UnityEngine;
using System.Collections;

public class WallFollowPlayer : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		GameObject head = GameObject.Find ("Head");
		transform.position = new Vector3(transform.position.x, transform.position.y, head.transform.position.z);

	}
}
