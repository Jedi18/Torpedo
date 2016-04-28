using System.Collections.Generic;
using UnityEngine;

public class Pool
{
    private List<GameObject> _poolList = new List<GameObject>();
    private GameObject _prefab;
    private GameObject _parent;

    public Pool(GameObject prefab)
    {
        _prefab = prefab;
        _parent = GameObject.Find(_prefab.name + "_pool");
        if (_parent == null)
            _parent = new GameObject(_prefab.name + "_pool");
    }

    public GameObject Get
    {
        get
        {
            for (int i = 0; i < _poolList.Count; i++)
            {
                if (!_poolList[i].activeInHierarchy)
                    return _poolList[i];
            }
            var obj = Object.Instantiate(_prefab);
            obj.transform.parent = _parent.transform;
            obj.gameObject.SetActive(false);
            _poolList.Add(obj);
            return obj;
        }
    }

    public void Destroy()
    {
        Object.Destroy(_parent);
    }
}
