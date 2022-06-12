using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BestScore : MonoBehaviour
{
    public void BestScoreCheck(int lastScore)
    {
        if(lastScore > PlayerPrefs.GetInt("BestScore"))
        {
            PlayerPrefs.SetInt("BestScore", lastScore);
        }
    }
}
