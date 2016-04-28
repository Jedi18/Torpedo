using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerInfo : MonoBehaviour {

	public int health = 3;
	public float score = 0;
	public Text scoreText;
	public Text healthText;

	// Use this for initialization
	void Start () {
		scoreText.text = "Score - " + score;
		healthText.text = "Lives - " + health;
	}
	
	// Update is called once per frame
	void Update () {
		score += Time.deltaTime;
		scoreText.text = "Score - " + Mathf.Round(score);
	}

	void reduceHealth(){
		health--;
		healthText.text = "Lives - " + health;
	}
}
