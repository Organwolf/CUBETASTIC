using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;

    private float playerScore;

    // Update is called once per frame
    void Update()
    {
        playerScore = PlayerPrefs.GetFloat("Player Score");
        float currentScore = playerScore + player.position.z;
        scoreText.text = "Score: " + currentScore.ToString("0");
    }
}
