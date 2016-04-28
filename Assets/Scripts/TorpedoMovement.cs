using UnityEngine;
using System.Collections;

public class TorpedoMovement : MonoBehaviour {

	Vector3 playerPos;
	GameObject player;
	float moveSpeed = 0.05f;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Submarine-temp");
	}
	
	// Update is called once per frame
	void Update () {

		playerPos = player.transform.position;

		// To face the player
		Vector3 dir = playerPos - transform.position;
		var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

		// move towards the player
		transform.Translate (Vector3.right * moveSpeed, Space.Self);
	
	}
}
