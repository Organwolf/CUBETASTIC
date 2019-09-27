using UnityEngine;
using UnityEngine.UI;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public Text scoreText;

    private void OnTriggerEnter(Collider other)
    {
        // Set score text inactive
        scoreText.enabled = false;
        gameManager.CompleteLevel();
    }
}
