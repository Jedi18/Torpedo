using UnityEngine;
using System.Collections;

public class ParallaxBackround : MonoBehaviour {

    public float speed = 0.5f;
	public GameObject player;

	void Start ()
    {
		player = GameObject.FindWithTag ("Player");
	}
	
	void Update ()
    {
        //GetComponent<Renderer>().material.mainTextureOffset = offset;

		float offsetX = 0;
		float offsetY = 0;


			//offsetX = Time.time * -speed;
			offsetX = player.transform.position.x;

			//offsetX = Time.time * speed;
			offsetX = player.transform.position.x;

            //offsetY = Time.time * -speed;
			offsetY = player.transform.position.y;

			//offsetY = Time.time * speed;
			offsetY = player.transform.position.y;

		Vector2 offset = new Vector2(offsetX,offsetY);
		GetComponent<Renderer>().material.mainTextureOffset = offset;
        Debug.Log(GetComponent<Renderer>().material.mainTextureOffset.ToString());
    }
}
