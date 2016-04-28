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
		float currentX = SubRigidbody.velocity.x;
		float currentY = SubRigidbody.velocity.y;

		if (Input.GetKey ("w")) 
		{
			currentX = MoveSpeed;
		}

		if (Input.GetKey ("s")) 
		{
			currentX = -MoveSpeed;
		}

		if (Input.GetKey ("a")) 
		{
			currentY = -MoveSpeed;
		}

		if (Input.GetKey ("d")) 
		{
			currentY = MoveSpeed;
		}

		SubRigidbody.velocity = new Vector2 (currentX,currentY);
	}
}
