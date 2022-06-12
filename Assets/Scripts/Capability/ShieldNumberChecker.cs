using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldNumberChecker : MonoBehaviour
{
    [SerializeField] private GameObject _buttonOfShield;
    private void Update()
    {
        if(DataForLevels.GetDatas.NumberOfCapabilityShield > 0)
        {
            _buttonOfShield.SetActive(true);
        }
        else
        {
            _buttonOfShield.SetActive(false);
        }
        
    }
}
