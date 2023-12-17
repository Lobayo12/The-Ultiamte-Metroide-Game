using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{

    public AudioMixer mainMixer;
    public void SetVolumeMusic(float volume)
    {
        mainMixer.SetFloat("volume", volume);
    }

    public void SetVolumeOther(float volume)
    {
        mainMixer.SetFloat("MyExposedParam", volume);
    }

    public void SetFullScreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}
