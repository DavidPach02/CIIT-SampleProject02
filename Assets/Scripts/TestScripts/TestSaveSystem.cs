using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSaveSystem : MonoBehaviour
{
    public static TestSaveSystem Instance { get; private set; }
    public bool loadLevel = false;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void QuickSave()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("CoinsCollected", TestGameManager.Instance.Score);
        PlayerPrefs.SetFloat("xPos", TestGameManager.Instance.player.transform.position.x);
        PlayerPrefs.SetFloat("yPos", TestGameManager.Instance.player.transform.position.y);

        Debug.Log("Saved file!");
    }

    public void LoadSave()
    {
        TestGameManager.Instance.Score = 0;
        TestGameManager.Instance.AddScore(PlayerPrefs.GetInt("CoinsCollected"));
        TestGameManager.Instance.player.transform.position = new Vector3(PlayerPrefs.GetFloat("xPos"), PlayerPrefs.GetFloat("yPos"));

        Debug.Log("Loaded file!");
    }
}
