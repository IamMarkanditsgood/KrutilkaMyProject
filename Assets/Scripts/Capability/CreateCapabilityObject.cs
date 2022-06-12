using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCapabilityObject : MonoBehaviour, ICreator
{
    [SerializeField] private Color [] _colorForCapabilityObject;
    private bool _recreateOfCapabilityObject;
    public void SetRecreator(bool Recreate)
    {
        this._recreateOfCapabilityObject = Recreate;
    }

    private void Start()
    {
        CreateNewFeatures();
    }
    private void Update()
    {
        if (gameObject.activeInHierarchy && _recreateOfCapabilityObject)
        {
            CreateNewFeatures();
            _recreateOfCapabilityObject = false;
        }
    }
    private void CreateNewFeatures()
    {
        CreateColorForCapabilityObject();
        CreateTagForCapabilityObject();
    }
    private void CreateColorForCapabilityObject()
    {
        gameObject.GetComponent<Renderer>().material.color = _colorForCapabilityObject[Random.Range(0, _colorForCapabilityObject.Length)];
    }
    private void CreateTagForCapabilityObject()
    {

        if (gameObject.GetComponent<Renderer>().material.color == new Color(1, 0, 0,1))
        {
            gameObject.tag = "Red";
        }
        else if (gameObject.GetComponent<Renderer>().material.color == new Color(1, 0.5f, 0, 1))
        {
            gameObject.tag = "Orange";
        }
        else if (gameObject.GetComponent<Renderer>().material.color == new Color(1, 1, 0, 1))
        {
            gameObject.tag = "Yellow";
        }
        else if (gameObject.GetComponent<Renderer>().material.color == new Color(0, 0.3f, 0, 1))
        {
            gameObject.tag = "Green";
        }
        else if (gameObject.GetComponent<Renderer>().material.color == new Color(0, 1, 1, 1))
        {
            gameObject.tag = "Azure";
        }
        else if (gameObject.GetComponent<Renderer>().material.color == new Color(0, 0, 1, 1))
        {
            gameObject.tag = "Blue";
        }
        else if (gameObject.GetComponent<Renderer>().material.color == new Color(0.3f, 0, 0.3f, 1))
        {
            gameObject.tag = "Purple";
        }
        else if (gameObject.GetComponent<Renderer>().material.color == new Color(1, 0, 1, 1))
        {
            gameObject.tag = "Pink";
        }
    }
}
