using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataForLevels : MonoBehaviour
{
    public static DataForLevels GetDatas;
    [SerializeField] private List<Transform> _startPositionForSpheres;
    [SerializeField] private List<Transform> _startPositionForCubes;
    [SerializeField] private float _speedForObjects;
    [SerializeField] private float _timeForSpavn;
    [SerializeField] private float _timeForChangingPosition;
    [SerializeField] private float _speedForRotation;
    [SerializeField] private int _scoreInCurrentLevel;
    [SerializeField] private int _levelComplexity;
    [SerializeField] private int _numberOfCapabilityShield;
    private bool _stateOfLevel = true;
    private bool _isShieldActive;
    


    private void Awake()
    {
        _stateOfLevel = true;
        GetDatas = this;
    }
    public List<Transform> StartPositionForSpheres
    {
        get { return _startPositionForSpheres; }
    }
    public List<Transform> StartPositionForCubes
    {
        get { return _startPositionForCubes; }
    }
    public bool IsShieldActive
    {
        get { return _isShieldActive; }
        set { _isShieldActive = value; }
    }
    public bool StateOfLevel
    {
        get { return _stateOfLevel; }
        set { _stateOfLevel = value; }
    }
    public float SpeedForRotation
    {
        get { return _speedForRotation; }
        set { _speedForRotation = value; }
    }
    public float SpeedForObjects
    {
        get { return _speedForObjects; }
        set { _speedForObjects = value; }
    }
    public float TimeForChangingPosition
    {
        get { return _timeForChangingPosition; }
        set { _timeForChangingPosition = value; }
    }
    public float TimeForSpavn
    {
        get { return _timeForSpavn; }
        set { _timeForSpavn = value; }
    }
    public int NumberOfCapabilityShield
    {
        get { return _numberOfCapabilityShield; }
        set { _numberOfCapabilityShield = value; }
    }
    public int ScoreInCurrentLevel
    {
        get { return _scoreInCurrentLevel; }
        set { _scoreInCurrentLevel = value; }
    }
    public int LevelComplexity
    {
        get { return _levelComplexity; }
        set { _levelComplexity = value; }
    }
}

