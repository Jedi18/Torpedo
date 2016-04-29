using UnityEngine;
using System.Collections;

public class SubControlScript : MonoBehaviour 
{
	public Rigidbody2D SubRigidbody;
	public float MoveSpeed = 5f;
	public float angleToRot = 40;

	void Start ()
	{
		SubRigidbody = gameObject.GetComponent<Rigidbody2D> ();
	}
	

	void Update () 
	{	

		if (Input.GetKey ("w")) 
		{
			SubRigidbody.velocity += (Vector2)transform.TransformDirection(Vector3.up) * MoveSpeed;
		}

		if (Input.GetKey ("s")) 
		{
			SubRigidbody.velocity -= (Vector2)transform.TransformDirection(Vector3.up) * MoveSpeed;
		}

		if (Input.GetKey ("a")) 
		{
			SubRigidbody.MoveRotation(angleToRot);
		}

		if (Input.GetKey ("d")) 
		{
			SubRigidbody.MoveRotation(-angleToRot);;
		}

	}

	void FixedUpdate()
	{

	}
}
