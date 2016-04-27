using UnityEngine;
using System.Collections;

public class SubControlScript : MonoBehaviour 
{
	public Rigidbody2D SubRigidbody;
	float MoveSpeed = 5f;

	void Start ()
	{
		SubRigidbody = gameObject.GetComponent<Rigidbody2D> ();
	}
	

	void Update () 
	{	
		if (Input.GetKey ("w")) 
		{
			SubRigidbody.velocity = new Vector2 (SubRigidbody.velocity.x, MoveSpeed);
		}

		if (Input.GetKey ("s")) 
		{
			SubRigidbody.velocity = new Vector2 (SubRigidbody.velocity.x, -MoveSpeed);
		}

		if (Input.GetKey ("a")) 
		{
			SubRigidbody.velocity = new Vector2 (-MoveSpeed,SubRigidbody.velocity.y );
		}

		if (Input.GetKey ("d")) 
		{
			SubRigidbody.velocity = new Vector2 (MoveSpeed,SubRigidbody.velocity.y );
		}
	}
}
