using System.Collections.Generic;
using UnityEngine;

public class SpavnSphere : MonoBehaviour, ISpavnAndGetObjects
{
    public static SpavnSphere ObjectInstance;
    [SerializeField] private List<GameObject> _pooledSphere = new List<GameObject>();
    [SerializeField] private GameObject _spherePrefab;
    [SerializeField] private int _spheresNumber;
    [SerializeField] private bool _shouldExpand;

    private void Awake()
    {
        ObjectInstance = this;
    }
    void Start()
    {
        for (int i = 0; i < _spheresNumber; i++)
        {
            CreateNewObject();
        }
    }
    public void CreateNewObject()
    {
        GameObject sphere = Instantiate(_spherePrefab);
        sphere.SetActive(false);
        _pooledSphere.Add(sphere);
    }
    public GameObject GetObject()
    {
        for (int i = 0; i < _pooledSphere.Count; i++)
        {
            if (!_pooledSphere[i].activeInHierarchy)
            {
                return _pooledSphere[i];
            }
        }
        if (_shouldExpand)
        {
            CreateNewObject();
            int _lastObjectInList = _pooledSphere.Count - 1;
            return _pooledSphere[_lastObjectInList];
        }
        else
        {
            return null;
        }
    }
}
