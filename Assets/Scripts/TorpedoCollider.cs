using UnityEngine;
using System.Collections;

public class TorpedoCollider : MonoBehaviour {

	public void OnTriggerEnter2D(Collider2D col)
	{
		
		if (col.gameObject.tag == "Player")
		{
			GameObject.Find("Main Camera").SendMessage("ShakeCamera");
			GameObject.FindWithTag("Player").SendMessage("reduceHealth");
			gameObject.SetActive(false);
		}

	}
}
