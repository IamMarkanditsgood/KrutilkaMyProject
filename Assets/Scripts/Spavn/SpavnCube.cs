using System.Collections.Generic;
using UnityEngine;

public class SpavnCube : MonoBehaviour, ISpavnAndGetObjects
{ 
    public static SpavnCube ObjectInstance;
    [SerializeField] private List<GameObject> _pooledCube = new List<GameObject>();
    [SerializeField] private GameObject _cubePrefab;
    [SerializeField] private int _cubeNumber;
    [SerializeField] private bool _shouldExpand;

    private void Awake()
    {
        ObjectInstance = this;
    }
    private void Start()
    {
        for (int i = 0; i < _cubeNumber; i++)
        {
            CreateNewObject();
        }
    }
    public void CreateNewObject()
    {
        GameObject cube = Instantiate(_cubePrefab);
        cube.SetActive(false);
        _pooledCube.Add(cube);
    }
    public GameObject GetObject()
    {
        for (int i = 0; i < _pooledCube.Count; i++)
        {
            if (!_pooledCube[i].activeInHierarchy)
            {
                return _pooledCube[i];
            }
        }
        if (_shouldExpand)
        {
            CreateNewObject();
            int _lastObjectInList = _pooledCube.Count - 1;
            return _pooledCube[_lastObjectInList];
        }
        else
        {
            return null;
        }
    }
}
