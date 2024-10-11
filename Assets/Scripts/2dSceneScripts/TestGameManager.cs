using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestGameManager : MonoBehaviour
{
    public static TestGameManager Instance;
    public int Score = 0;
    public int Lives = 3;
    public TextMeshProUGUI ScoreText;

    private float _baseJumpValue;
    private float _modifiedJumpValue;

    public Camera _camera;
    public TestPlayer player;

    void Awake ()
    {
        Instance = this;
    }

    void Start()
    {
        ScoreText.text = "0";
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<TestPlayer>();
        _camera.GetComponent<CameraFollow>().playerRef = player;

        //Debug.Log(TestSaveSystem.Instance.loadLevel);
        if (TestSaveSystem.Instance.loadLevel)
        {
            Load();
        }
    }

    //COIN
    public void AddScore(int value) 
    {
        Score = Score + value;
        ScoreText.text = Score.ToString();
    }

    public void SetScore(int value)
    {
        // Set score value
        Score = value;
        // Update text
        ScoreText.text = Score.ToString();
    }

    public void ReduceLives (int value)
    {
        Lives = Lives - value;
    }

    public int GetLives ()
    {
        return Lives;
    }
    //POWER UP

    public void GetBaseJumpValue (float value)
    {
        _baseJumpValue = value;
    }

    public void ModifyJump (float value)
    {
        _modifiedJumpValue = _baseJumpValue + value;
    }

    public float SetJumpValue ()
    {
        return _modifiedJumpValue;
    }

    public void Save()
    {
        TestSaveSystem.Instance.QuickSave();
    }

    public void Load()
    {
        TestSaveSystem.Instance.LoadSave();
    }
}
