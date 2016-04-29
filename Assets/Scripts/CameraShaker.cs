using UnityEngine;
using Random = UnityEngine.Random;

public class CameraShaker : MonoBehaviour {

	
	public float timeToShake = 0.5f;
	public float shakeAmount = 0.5f;
	public bool isShaking = false;

    private Vector3 initialPosition;
    private float shakeTimer;
	GameObject submarine;
	public Transform submarineTransform;
	Vector3 submarinePos;

    void Start()
	{
		isShaking = false;
		submarine = GameObject.FindWithTag("Player");
		submarineTransform = submarine.GetComponent<Transform> ();
	}
	
	public void Update()
	{
		submarinePos = submarineTransform.position;
		submarinePos.z = -10;
		//camera movement
		transform.position = submarinePos;

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
