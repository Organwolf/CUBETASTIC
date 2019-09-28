using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTotalScore : MonoBehaviour
{
    public Text totalScore;

    private void Start()
    {
        totalScore.text = "Total score: " + PlayerPrefs.GetFloat("Player Score").ToString("0");
    }
}
