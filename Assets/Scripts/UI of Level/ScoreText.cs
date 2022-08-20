using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreTect;

    void Update()
    {
        _scoreTect.text = DataForLevels.GetDatas.ScoreInCurrentLevel.ToString();
    }
}
