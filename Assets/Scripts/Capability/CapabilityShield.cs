using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapabilityShield : MonoBehaviour
{
    [SerializeField] private float _finishTime = 3;
    private float _curentTime;
    private void Update()
    {
        _curentTime += Time.deltaTime;
        if(_curentTime >= _finishTime)
        {
            _curentTime = 0;
            DataForLevels.GetDatas.IsShieldActive = false;
            gameObject.SetActive(false);
        }
    }


}
