using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLoader : MonoBehaviour
{
    public AudioManager theAM;

    private void Awake()
    {
        // Takes care of sound
        if(AudioManager.instance == null)
        {
            AudioManager newAM = Instantiate(theAM);
            AudioManager.instance = newAM;
            DontDestroyOnLoad(newAM.gameObject);
        }
    }

}
