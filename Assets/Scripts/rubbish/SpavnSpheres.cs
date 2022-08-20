using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpavnSpheres : MonoBehaviour
{
    public static SpavnSpheres SharedInstance;
    [SerializeField] private List<GameObject> _pooledSphere = new List<GameObject>();
    [SerializeField] private List<GameObject> _pooledCube = new List<GameObject>();
    [SerializeField] private GameObject _spherePrefab;
    [SerializeField] private GameObject _cubePrefab;
    [SerializeField] private GameObject _capabilityPrefab;
    private GameObject Ability;
    [SerializeField] private int _spheresAndCubesNumber = 5;
    [SerializeField] private bool _shouldExpand = true;
      
        
    private void Awake()
    {
        SharedInstance = this;
    }
    private void Start()
    {
        FirstSpavnOfObjects();        
    }
        
    private void FirstSpavnOfObjects()
    {
        for (int i = 0; i < _spheresAndCubesNumber; i++)
        {
            CreateNewSphere();
            CreateNewCube();
        }
        CreateNewCapabilityObject();


    }
    private void CreateNewCapabilityObject()
    {
        Ability  = Instantiate(_capabilityPrefab);
        Ability.SetActive(false);
    }
    private void CreateNewSphere()
    {
        GameObject sphere = Instantiate(_spherePrefab);
        sphere.SetActive(false);
        _pooledSphere.Add(sphere);

    }
    private void CreateNewCube()
    {
        GameObject cube = Instantiate(_cubePrefab);
        cube.SetActive(false);
        _pooledCube.Add(cube);
    }
    public GameObject GetCapabilityObject()
    {
        if (!Ability.activeInHierarchy)
        {
            return Ability;
        }
        else
        {
            return GetSphere();
        }
    }
    public GameObject GetCube()
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
            CreateNewCube();
            int _lastObjectInList = _pooledCube.Count - 1;
            return _pooledCube[_lastObjectInList];
        }
        else
        {
            return null;
        }
    }
    public GameObject GetSphere()
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
                CreateNewSphere();
                int _lastObjectInList = _pooledSphere.Count - 1;
                return _pooledSphere[_lastObjectInList];
            }
            else
            {
                return null;
            }
    }
}

