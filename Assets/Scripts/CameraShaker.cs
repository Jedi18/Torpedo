using UnityEngine;
using System.Collections;

public class CameraShaker : MonoBehaviour {

	private float shakeTimer = 0.0f;
	public float shakeTimerA = 0.5f;
	public float shakeAmount = 0.5f;
	public bool isShaking = false;
	public GameObject theCamera;
	
	void Start()
	{
		isShaking = false;
	}
	
	public void Update()
	{
		if (isShaking == true)
		{
			shakeTimer = shakeTimerA;
		}
		if (shakeTimer > 0)
		{
			
			Vector2 ShakePos = Random.insideUnitCircle * shakeAmount;
			
			transform.position = new Vector2(transform.position.x + ShakePos.x, transform.position.y + ShakePos.y);
			
			shakeTimer -= Time.deltaTime;
			
			//Destroy(gameObject);
		}
	}

	public void ShakeCamera(){

		Debug.Log ("Shake the camera!");
		isShaking = true;

	}
}
