using UnityEngine;
using System.Collections;

public class BackGroundControl : MonoBehaviour {

	private Transform cameraTransform;
	private float spriteWidth;
	private float spriteHeight;

	// Use this for initialization
	void Start () {
	
		cameraTransform = Camera.main.transform;
		
		SpriteRenderer spriteRenderer = GetComponent<Renderer>() as SpriteRenderer;
		spriteWidth = spriteRenderer.sprite.bounds.size.x;
		spriteHeight = spriteRenderer.sprite.bounds.size.y;

	}
	
	// Update is called once per frame
	void Update () {

		// If we move change background pos
	
		// right 
		if ((transform.position.x + spriteWidth) < cameraTransform.position.x) {
			
			Vector3 newPos = transform.position;
			newPos.x += 2.0f * spriteWidth;
			transform.position = newPos;
			
		}

		// left
		if ((transform.position.x - spriteWidth) > cameraTransform.position.x) {
			
			Vector3 newPos = transform.position;
			newPos.x -= 2.0f * spriteWidth;
			transform.position = newPos;
			
		}


		// top
		if ((transform.position.y + spriteHeight) < cameraTransform.position.y) {
			
			Vector3 newPos = transform.position;
			newPos.y += 2.0f * spriteHeight;
			transform.position = newPos;
			
		}

		// down
		if ((transform.position.y - spriteHeight) > cameraTransform.position.y) {
			
			Vector3 newPos = transform.position;
			newPos.y -= 2.0f * spriteHeight;
			transform.position = newPos;
			
		}

	}
}
