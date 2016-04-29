using UnityEngine;
using Random = UnityEngine.Random;

public class ShakeBehaviour : MonoBehaviour {

	
	[SerializeField] private float _timeToShake = 0.5f;
    [SerializeField] private float _shakeAmount = 0.5f;

    private bool _isShaking = false;
    private Vector3 _initialPosition;
    private float _shakeTimer;
    private FollowBehaviour2D _followBehaviour;

    void Start()
	{
        _isShaking = false;
        _followBehaviour = GetComponent<FollowBehaviour2D>();
	}
	
	public void Update()
	{
	    if (!_isShaking)
	        return;

        _shakeTimer += Time.deltaTime;
		if (_shakeTimer <= _timeToShake)
		{
			Vector2 shakeOffset = Random.insideUnitCircle * _shakeAmount;
		    Vector3 newPosition;

            // take target of followBehaviour into account if followBehaviour is attached
		    if (_followBehaviour != null)
		        newPosition = new Vector3(_followBehaviour.Position.x + shakeOffset.x, _followBehaviour.Position.y + shakeOffset.y, _followBehaviour.Position.z);
		    else
                newPosition = new Vector3(_initialPosition.x + shakeOffset.x, _initialPosition.y + shakeOffset.y, _initialPosition.z);

		    transform.localPosition = newPosition;

		}
		else
		{
            // Same as above
		    if (_followBehaviour != null)
		        transform.localPosition = _followBehaviour.Position;
            else
		        transform.localPosition = _initialPosition;
            _isShaking = false;
		}
        
	}

	public void StartShaking()
    {
	    if (!_isShaking)
	    {
            _isShaking = true;
            _initialPosition = transform.localPosition;
        }
        // not in the if body because we want to reset the shake duration everytime the camera should be shaken
        _shakeTimer = 0;
    }
}
