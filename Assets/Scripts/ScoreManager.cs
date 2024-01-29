using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI inputScore;

    [SerializeField]
    private TMP_InputField inputName;

    public UnityEvent<string, float> submitScoreEvent;

    public void SubmitScore()
    {
        submitScoreEvent.Invoke(inputName.text, float.Parse(inputScore.text));
    }
}
