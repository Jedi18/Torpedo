using UnityEngine;
using System.Collections;

public class SubControlScript : MonoBehaviour 
{
	public Rigidbody2D SubRigidbody;
	public float MoveSpeed = 5f;
	public GameObject ExplosionGo;

	void Start ()
	{
		SubRigidbody = gameObject.GetComponent<Rigidbody2D> ();
	}
	

	void Update ()
	{	
		float currentX = SubRigidbody.velocity.x;
		float currentY = SubRigidbody.velocity.y;

		if (Input.GetKey ("w")) {
			currentY = MoveSpeed;
		}

		if (Input.GetKey ("s")) {
			currentY = -MoveSpeed;
		}

		if (Input.GetKey ("a")) {
			currentX = -MoveSpeed;
		}

		if (Input.GetKey ("d")) {
			currentX = MoveSpeed;
		}


		SubRigidbody.velocity = new Vector2 (currentX, currentY);
	}
		



	}


