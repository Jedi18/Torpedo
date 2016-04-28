using UnityEngine;
using System.Collections;

public class PlayerInfo : MonoBehaviour {

	public int health;
	public float score;

	// Use this for initialization
	void Start () {
		health = 3;
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		score += Time.deltaTime;
	}

	void reduceHealth(){
		health--;
		Debug.Log ("Health - "+ health);
		Debug.Log("Score - "+ score);
	}
}
