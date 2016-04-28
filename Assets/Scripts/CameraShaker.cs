using UnityEngine;
using Random = UnityEngine.Random;

public class CameraShaker : MonoBehaviour {

	
	public float timeToShake = 0.5f;
	public float shakeAmount = 0.5f;
	public bool isShaking = false;

    private Vector3 initialPosition;
    private float shakeTimer;

    void Start()
	{
		isShaking = false;
	}
	
	public void Update()
	{
	    if (!isShaking)
	        return;

	    shakeTimer += Time.deltaTime;
		if (shakeTimer <= timeToShake)
		{
			Vector3 shakeOffset = Random.insideUnitCircle * shakeAmount;

			transform.localPosition = new Vector3(initialPosition.x + shakeOffset.x, initialPosition.y + shakeOffset.y, initialPosition.z);
		}
		else
		{
		    transform.localPosition = initialPosition;
		    isShaking = false;
		}
        
	}

	public void ShakeCamera()
    {
	    if (!isShaking)
	    {
            isShaking = true;
            initialPosition = transform.localPosition;
        }
        // not in the if body because we want to reset the shake duration everytime the camera should be shaken
	    shakeTimer = 0;
    }
}
