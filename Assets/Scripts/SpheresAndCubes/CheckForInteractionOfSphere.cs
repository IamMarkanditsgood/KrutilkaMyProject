using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForInteractionOfSphere : MonoBehaviour
{
    [SerializeField] private CreatorOfSphers _creatorOfSpheres;
    [SerializeField] private CreateCubes _creatorOfCubes;
    [SerializeField] private CreateCapabilityObject _creatorOfCapabilityObject;
    private ICreator _creatorScript;
    private bool _isCapability = false;
    private void Start()
    {
        if (gameObject.layer == LayerMask.NameToLayer("Sphere"))
        {
            _creatorScript = _creatorOfSpheres;
        }
        else if(gameObject.layer == LayerMask.NameToLayer("Cube"))
        {
            _creatorScript = _creatorOfCubes;
        }
        else if (gameObject.layer == LayerMask.NameToLayer("Capability"))
        {
            _creatorScript = _creatorOfCapabilityObject;
            _isCapability = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == gameObject.tag)
        {
            CorrectHit();  
        }
        else if(other.gameObject.tag == "Shield")
        {
            Destroy(gameObject.GetComponent<Teleporter>());
            _creatorScript.SetRecreator(true);
            gameObject.SetActive(false);
        }
        else
        {
            DataForLevels.GetDatas.StateOfLevel = false;
            StartLosseButton.startLosseButton.LoadLosseMenu();
            Time.timeScale = 0;
            BestScore bestScore = new BestScore();
            bestScore.BestScoreCheck(DataForLevels.GetDatas.ScoreInCurrentLevel);
            gameObject.SetActive(false);
        }
    }
    private void CorrectHit()
    {
        if(_isCapability)
        {
            DataForLevels.GetDatas.NumberOfCapabilityShield++;
            
        }
        DataForLevels.GetDatas.ScoreInCurrentLevel++;
        Destroy(gameObject.GetComponent<Teleporter>());
        _creatorScript.SetRecreator(true);
        gameObject.SetActive(false);
        
    }
}
