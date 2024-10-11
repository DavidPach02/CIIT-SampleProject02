using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public TestGameManager gameManager;

    public void SaveGame()
    {
        // Save score
        PlayerPrefs.SetInt("PlayerScore", gameManager.Score);
        Debug.Log("Saved current score: " + gameManager.Score);

        // Save xPosition
        PlayerPrefs.SetFloat("playerXPosition", gameManager.player.transform.position.x);
        // Save yPosition
        PlayerPrefs.SetFloat("playerYPosition", gameManager.player.transform.position.y);
        Debug.Log("Saved current position: [" + gameManager.player.transform.position.x + " , " + gameManager.player.transform.position.y + "]");
    }

    public void LoadGame()
    {
        // Load score
        int score = PlayerPrefs.GetInt("PlayerScore");
        gameManager.SetScore(score);
        Debug.Log("Score: " + score);

        // Load xPosition
        float xPosition = PlayerPrefs.GetFloat("playerXPosition");
        // Load yPosition
        float yPosition = PlayerPrefs.GetFloat("playerYPosition");
        gameManager.player.transform.position = new Vector3(xPosition, yPosition, 0.0f);

        Debug.Log("Loaded current position: [" + gameManager.player.transform.position.x + " , " + gameManager.player.transform.position.y + "]");
    }
}
