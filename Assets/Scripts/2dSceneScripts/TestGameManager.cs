using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestGameManager : MonoBehaviour
{
    public static TestGameManager instance;
    public int Score = 0;
    public int Lives = 3;
    public TextMeshProUGUI ScoreText;

    private float _baseJumpValue;
    private float _modifiedJumpValue;

    public Camera _camera;
    public TestPlayer _player;

    void Awake ()
    {
        instance = this;
    }

    void Start()
    {
        ScoreText.text = "0";
        _camera.GetComponent<CameraFollow>().playerRef = _player;
    }

    //COIN
    public void AddScore(int value) 
    {
        Score = Score + value;
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
}
