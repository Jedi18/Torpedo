using UnityEngine;
using System.Collections;

public class mousesubcontrol : MonoBehaviour {

	private Vector3 mousePosition;
	public float distance = 5.0f;

	void Start () {
	
	}

	void Update () {

		Vector3 mousePosition = Input.mousePosition;
		mousePosition.z = distance;
		transform.position= Camera.main.ScreenToWorldPoint (Input.mousePosition);
	
	}

}
