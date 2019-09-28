using UnityEngine;

public class InitialScore : MonoBehaviour
{
    private int initialScore = 0;

    private void Awake()
    {
        // PlayerPrefs -> set the score to 0
        PlayerPrefs.SetFloat("Player Score", initialScore);
    }
}
