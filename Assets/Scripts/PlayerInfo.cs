using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerInfo : MonoBehaviour {

	public int health = 3;
	public float score = 0;
	public Text scoreText;
	public Text healthText;
	public bool isAlive;

	// Use this for initialization
	void Start () {
		scoreText.text = "Score - " + score;
		healthText.text = "Lives - " + health;
		isAlive = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (isAlive) {
			score += Time.deltaTime;
			scoreText.text = "Score - " + Mathf.Round (score);
		}
	}

	void reduceHealth(){
		health--;
		healthText.text = "Lives - " + health;

		if(health <= 0){
			RIP();
		}
	}

	void RIP(){
		Debug.Log ("Game Over");
		isAlive = false;
		Debug.Log ("Score - " + Mathf.Round (score));
		GetComponent<SubControlScript> ().enabled = false;
		GameObject.Find("TorpedoSpawner").GetComponent<TorpedoSpawner>().enabled = false;
		GameObject[] enemyList = GameObject.FindGameObjectsWithTag ("Enemy");

		for (int i=0; i<enemyList.Length; i++) {

			Destroy(enemyList[i]);

		}

	}
}
