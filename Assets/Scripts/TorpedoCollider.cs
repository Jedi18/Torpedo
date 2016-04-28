using UnityEngine;
using System.Collections;

public class TorpedoCollider : MonoBehaviour
{

    public float shakeTimer;
    public float shakeAmount;
    //float shakeDur = 0.1f;
    //float shakePwr = 1;
    public bool isShaking;
	public GameObject theCamera;

    void Start()
    {
        isShaking = false;
        ShakeCamera(0.0f, 0.0f);
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
            ShakeCamera(0.1f, 0.05f);
        }
        if (shakeTimer > 0)
        {

            Vector2 ShakePos = Random.insideUnitCircle * shakeAmount;

           theCamera.transform.position = new Vector2(transform.position.x + ShakePos.x, transform.position.y + ShakePos.y);

            shakeTimer -= Time.deltaTime;
        }
    }

    public void ShakeCamera(float shakeDur, float shakePwr)
    {

        shakeAmount = shakePwr;
        shakeTimer = shakeDur;
    }


}
