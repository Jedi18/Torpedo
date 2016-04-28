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
		Vector3 originalPos = transform.position;

		if (isShaking == true)
		{
			shakeTimer = shakeTimerA;
		}
		if (shakeTimer > 0)
		{

			Vector3 ShakePos = Random.insideUnitCircle * shakeAmount;
			
			transform.position = new Vector3(transform.position.x + ShakePos.x, transform.position.y + ShakePos.y,transform.position.z);
			
			shakeTimer -= Time.deltaTime;

			isShaking = false;

		}

		if(shakeTimer == 0){
			transform.position = originalPos;
		}
	}

	public void ShakeCamera(){

		isShaking = true;

	}
}
