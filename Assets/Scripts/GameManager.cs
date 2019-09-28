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
    }
}
