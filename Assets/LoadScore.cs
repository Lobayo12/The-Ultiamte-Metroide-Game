using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class LoadScore : MonoBehaviour
{

    public Text scoreText;

    public float score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string loadedVariable = PlayerPrefs.GetString("Score playerPrefs");

        scoreText.text =  loadedVariable.ToString();
    }

}
