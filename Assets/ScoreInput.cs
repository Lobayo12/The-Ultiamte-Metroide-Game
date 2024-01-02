using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using UnityEngine.UI;

public class ScoreInput : MonoBehaviour
{
    public TimeAndScore timeAndScore;
    public float gameScore;
    public Text scoreLeaderboard;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeAndScore.currentTime = gameScore;
        scoreLeaderboard.text = gameScore.ToString();
    }
}
