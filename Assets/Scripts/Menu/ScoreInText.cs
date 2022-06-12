using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreInText : MonoBehaviour
{
    [SerializeField] private Text TextForScore;
    private void Start()
    {
        TextForScore.text = PlayerPrefs.GetInt("BestScore").ToString();
    }
}
