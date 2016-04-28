using UnityEngine;
using System.Collections;

public class ParallaxBackround : MonoBehaviour {

    public float speed = 0.5f;

	void Start ()
    {
	
	}
	
	void Update ()
    {
        //GetComponent<Renderer>().material.mainTextureOffset = offset;

		float offsetX = 0;
		float offsetY = 0;

        if (Input.GetKey(KeyCode.A))
        {
			offsetX = Time.time * -speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
			offsetX = Time.time * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            offsetY = Time.time * -speed;
        }
        if (Input.GetKey(KeyCode.W))
        {
			offsetY = Time.time * speed;
        }

		Vector2 offset = new Vector2(offsetX,offsetY);
		GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
