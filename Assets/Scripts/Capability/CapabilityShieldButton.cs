using UnityEngine;

public class CapabilityShieldButton : MonoBehaviour
{
    [SerializeField] private GameObject _shield;
    [SerializeField] private GameObject _shieldTimer;
    [SerializeField] private ClickButtonSound _sound;
    public void PressingButton()
    {
        if (DataForLevels.GetDatas.NumberOfCapabilityShield != 0 && !DataForLevels.GetDatas.IsShieldActive)
        {
            _sound.ClickSound();
            DataForLevels.GetDatas.IsShieldActive = true;
            _shield.SetActive(true);
            _shieldTimer.SetActive(true);
            DataForLevels.GetDatas.NumberOfCapabilityShield--;
        }
    }
}
