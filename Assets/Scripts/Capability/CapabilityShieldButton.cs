using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapabilityShieldButton : MonoBehaviour
{
    [SerializeField] private GameObject _shield;
    
    public void PressingAButton()
    {
        if (DataForLevels.GetDatas.NumberOfCapabilityShield != 0 && !DataForLevels.GetDatas.IsShieldActive)
        {
            DataForLevels.GetDatas.IsShieldActive = true;
            _shield.SetActive(true);
            DataForLevels.GetDatas.NumberOfCapabilityShield--;
        }
    }
}
