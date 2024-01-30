using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using UnityEngine.UI;


public class TimeAndScore : MonoBehaviour
{
    public float startTime = 0;

    
    public float currentTime;

    public int score;

    public string currentTimeString;


    public Text textbox;


    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(gameObject);
        currentTime += Time.deltaTime;
        score = ((int)currentTime);
        textbox.text = score.ToString();

        currentTimeString = score.ToString();

        PlayerPrefs.SetString("Score playerPrefs", currentTimeString);
        PlayerPrefs.Save();
    }
}
