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

        if (Input.GetKey(KeyCode.A))
        {
            Vector2 offset = new Vector2(Time.time * -speed, 0);
            GetComponent<Renderer>().material.mainTextureOffset = offset;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector2 offset = new Vector2(Time.time * speed, 0);
            GetComponent<Renderer>().material.mainTextureOffset = offset;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector2 offset = new Vector2(0, Time.time * -speed);
            GetComponent<Renderer>().material.mainTextureOffset = offset;
        }
        if (Input.GetKey(KeyCode.W))
        {
            Vector2 offset = new Vector2(0, Time.time * speed);
            GetComponent<Renderer>().material.mainTextureOffset = offset;
        }
    }
}
