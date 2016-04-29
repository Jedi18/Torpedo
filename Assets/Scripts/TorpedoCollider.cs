using UnityEngine;
using System.Collections;

public class TorpedoCollider : MonoBehaviour
{

    private ShakeBehaviour _cameraShakeBehaviour;
    private PlayerInfo _playerInfo;

    void Awake()
    {
        _cameraShakeBehaviour = Camera.main.GetComponent<ShakeBehaviour>();
        _playerInfo = GameObject.FindWithTag("Player").GetComponent<PlayerInfo>();
    }


	public void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag("Player"))
		{
            _cameraShakeBehaviour.StartShaking();
			_playerInfo.reduceHealth();
			gameObject.SetActive(false);
		}
	}
}
