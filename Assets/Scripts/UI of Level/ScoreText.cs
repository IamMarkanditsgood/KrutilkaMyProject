using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    [SerializeField] private Text _scoreTect;
    void Update()
    {
        _scoreTect.text = DataForLevels.GetDatas.ScoreInCurrentLevel.ToString();
    }
}
