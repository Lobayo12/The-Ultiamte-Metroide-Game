using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
        public void AdventureMode()
        {
            SceneManager.LoadScene("Area 1 Adventure");
        }

        public void TimerMode()
        {
            SceneManager.LoadScene("Area 1 Timer");
        }
    
}
