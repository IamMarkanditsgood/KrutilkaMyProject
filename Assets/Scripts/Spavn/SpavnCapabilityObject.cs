using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpavnCapabilityObject : MonoBehaviour, ISpavnAndGetObjects
{
    public static SpavnCapabilityObject ObjectInstance;
    [SerializeField] private GameObject _capabilityPrefab;
    private GameObject Ability;

    private void Awake()
    {
        ObjectInstance = this;
    }
    void Start()
    {
        CreateNewObject();
    }
    public void CreateNewObject()
    {
        Ability = Instantiate(_capabilityPrefab);
        Ability.SetActive(false);
    }
    public GameObject GetObject()
    {
        if (!Ability.activeInHierarchy)
        {
            return Ability;
        }
        else
        {
            return null;
        }
    }
}
