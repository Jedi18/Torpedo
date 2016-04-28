using UnityEngine;
using System.Collections;

public class TorpedoColliderEEEEEE : MonoBehaviour
{

    private float shakeTimer = 0.0f;
	public float shakeTimerA = 0.5f;
    public float shakeAmount = 0.5f;
    //float shakeDur = 0.1f;
    //float shakePwr = 1;
    public bool isShaking = false;
	public GameObject theCamera;

    void Start()
    {
        isShaking = false;
        //ShakeCamera(shakeTimer, shakeAmount);
        //theCamera = GameObject.Find ("Main Camera");
    }

    public void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Player")
        {
            isShaking = true;
        }
        else
        {
            isShaking = false;
        }
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

           theCamera.transform.position = new Vector2(theCamera.transform.position.x + ShakePos.x, theCamera.transform.position.y + ShakePos.y);

            shakeTimer -= Time.deltaTime;

			//Destroy(gameObject);
        }
    }


}
