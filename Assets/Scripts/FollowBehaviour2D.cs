using UnityEngine;

public class FollowBehaviour2D : MonoBehaviour
{
    [SerializeField] private Transform _targetTransform;
    [SerializeField] private Vector2 _offset;

    private Transform _transform;

    public Vector3 Position { get { return _transform.position; } }

    void Awake()
    {
        // this.transform makes a call to GetComponent<Transform>
        // this is a chached reference
        _transform = transform;
    }

	void Update ()
    {
        // Set position to targets position with offset, but keep the z 
	    _transform.position = new Vector3(_targetTransform.position.x + _offset.x, _targetTransform.position.y + _offset.y, _transform.position.z);
	}
}
