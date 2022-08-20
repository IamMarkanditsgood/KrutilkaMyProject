using UnityEngine;
using TMPro;
public class ShieldNumberChecker : MonoBehaviour
{
    [SerializeField] private GameObject _buttonOfShield;
    [SerializeField] private TMP_Text _numberOfShields;
    private void Update()
    {
        _numberOfShields.text = DataForLevels.GetDatas.NumberOfCapabilityShield.ToString();
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
