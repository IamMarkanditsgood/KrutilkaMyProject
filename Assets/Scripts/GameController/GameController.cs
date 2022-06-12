using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private float _timer = 0;
    private int _randomNumberOfPosition;
    private Transform _startPositionForSpavn;
    private void Awake()
    {
        Time.timeScale = 0;
    }
    private void FixedUpdate()
    {
        _timer += Time.deltaTime;
        if (_timer > DataForLevels.GetDatas.TimeForSpavn)
        {
            GameObject bullet = GetObject();
            if (bullet != null)
            {
                
                bullet.transform.position = _startPositionForSpavn.position;
                bullet.SetActive(true);

            }
            _timer = 0;
        }
    }
    private GameObject GetObject()
    {
        switch (DataForLevels.GetDatas.LevelComplexity)
        {
            case 0:
                ChoisePositionForSphere();
                return SpavnSphere.ObjectInstance.GetObject();
                
            case 1:
                return RandomObject(1);
                
            case 2:
                return RandomObject(2);
                
            default:
                return RandomObject(3);
                

        }

    }
    private GameObject RandomObject(int numberOfObjects)
    {
        GameObject[] objects = {SpavnSphere.ObjectInstance.GetObject(), SpavnCube.ObjectInstance.GetObject(), SpavnCapabilityObject.ObjectInstance.GetObject() };
        int randProcent = Random.Range(0, 101);
        switch(numberOfObjects)
        {
            case 1:
                if(randProcent <= 50)
                {
                    ChoisePositionForSphere();
                    return objects[0];
                }
                else if (randProcent > 50)
                {
                    ChoisePositionForCubes();
                    return objects[1];
                }
                
                break;
            case 2:
                if (randProcent <= 73)
                {
                    ChoisePositionForSphere();
                    return objects[0];
                }
                else if (randProcent > 73 && randProcent < 98)
                {
                    ChoisePositionForCubes();
                    return objects[1];
                }
                else
                {
                    ChoisePositionForSphere();
                    return objects[2];
                }
               
                
            default:
                if (randProcent <= 73)
                {
                    ChoisePositionForSphere();
                    return objects[0];
                }
                else if (randProcent > 73 && randProcent < 98)
                {
                    ChoisePositionForCubes();
                    return objects[1];
                }
                else
                {
                    ChoisePositionForSphere();
                    return objects[2];
                }
                
                
        }
        return null;
    }
    private void ChoisePositionForSphere()
    {
        _randomNumberOfPosition = Random.Range(0, DataForLevels.GetDatas.StartPositionForSpheres.Count);
        _startPositionForSpavn = DataForLevels.GetDatas.StartPositionForSpheres[_randomNumberOfPosition];
    }
    private void ChoisePositionForCubes()
    {
        _randomNumberOfPosition = Random.Range(0, DataForLevels.GetDatas.StartPositionForCubes.Count);
        _startPositionForSpavn = DataForLevels.GetDatas.StartPositionForCubes[_randomNumberOfPosition];

    }
}

