using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1;
    public GameObject completeLevelUI;
    public Transform player;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            //var prevScore = PlayerPrefs.GetFloat("Player Score");
            //var prevScore = 0f;
            //var currentScore = prevScore + player.position.z;
            //PlayerPrefs.SetFloat("Players Score", currentScore);
            //Debug.Log("Total Score: " + currentScore);
            //Debug.Log("Total Score: " + PlayerPrefs.GetFloat("Player Score"));
            Invoke("Restart", restartDelay);
        }
    }

    void Restart ()
    {
        SceneManager.LoadScene("Level01");
    }

    public void CompleteLevel()
    {
        PlayerPrefs.SetFloat("Player Score", PlayerPrefs.GetFloat("Player Score") + player.position.z);
        completeLevelUI.SetActive(true);
        Debug.Log("Score:" + PlayerPrefs.GetFloat("Player Score").ToString("0"));
        Debug.Log("Completed Level!");
    }
}
