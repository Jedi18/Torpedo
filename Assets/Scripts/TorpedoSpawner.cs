using UnityEngine;

public class TorpedoSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _torpedoPrefab;
    [SerializeField] [Range(1, 360)] private float _possibleSpawnAngle = 360f;
    [SerializeField] private float _radius = 10f;
    [SerializeField] private float _timeBetweenSpawns = 0.25f;

    private Pool _torpedoPool;
    private float _currentTime = 0;

    void Start()
    {
        _torpedoPool = new Pool(_torpedoPrefab);
       
    }

    void Update()
    {
        _currentTime += Time.deltaTime;
        if (_currentTime >= _timeBetweenSpawns)
        {
            Spawn();
            _currentTime = 0;
        }
    }

    void Spawn()
    {
        var radianAngle = Random.Range(0, _possibleSpawnAngle)*Mathf.Deg2Rad;
        var x = _radius * Mathf.Cos(radianAngle);
        var y = _radius * Mathf.Sin(radianAngle);
        var position = new Vector3(x + Camera.main.transform.position.x, y + Camera.main.transform.position.y, 0);
        var torpedo = _torpedoPool.Get;
        torpedo.transform.position = position;
        torpedo.SetActive(true);
    }
}
