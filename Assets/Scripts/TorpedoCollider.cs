using UnityEngine;
using System.Collections;

public class TorpedoCollider : MonoBehaviour {

	public GameObject ExplosionGo;

	public void OnCollisionEnter2D(Collision2D col)
	{
		
		if (col.gameObject.tag == "Player") {
			GameObject.Find ("Main Camera").SendMessage ("ShakeCamera");
			GameObject.FindWithTag ("Player").SendMessage ("reduceHealth");
			gameObject.SetActive (false);
			PlayExplosion ();
		}

	}
		void PlayExplosion ()
		{
			GameObject explosion = (GameObject)Instantiate (ExplosionGo);
			explosion.transform.position= transform.position;
	}
}
