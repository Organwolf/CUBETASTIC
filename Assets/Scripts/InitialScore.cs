using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialScore : MonoBehaviour
{
    private int initialScore = 0;

    private void Awake()
    {
        // PlayerPrefs -> set the score to 0
        PlayerPrefs.SetFloat("Player Score", initialScore);
        //PlayerPrefs.SetFloat("Player Score", 14.5f);
        //Debug.Log(PlayerPrefs.GetFloat("Player Score"));

    }
}
