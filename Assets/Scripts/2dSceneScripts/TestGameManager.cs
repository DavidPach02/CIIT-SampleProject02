using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestGameManager : MonoBehaviour
{
    public static TestGameManager instance;
    public int Score = 0;
    public TextMeshProUGUI ScoreText;

    private float _baseJumpValue;
    private float _modifiedJumpValue;

    void Awake ()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "0";
    }

    //COIN

    public void AddScore(int value) 
    {
        Score = Score + value;
        ScoreText.text = Score.ToString();
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