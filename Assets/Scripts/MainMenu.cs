using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private UIController uiController;

    public string newGameScene;

    public GameObject continueButton;
    public GameObject leaderboardButton;

    public PlayerAbilityTracker player;
    



    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("ContinueLevel"))
        {
            continueButton.SetActive(true);
        }

        AudioManager.instance.PlayMainMenuMusic();
    }

    // Just restarts a new game when button pushed
    public void NewGame()
    {
        PlayerPrefs.DeleteAll();

        SceneManager.LoadScene("Choose the mode");
    }

    // Restarts from where the player was with the diffrent abbilites...
    public void Continue()
    {
        player.gameObject.SetActive(true);
        player.transform.position = new Vector3(PlayerPrefs.GetFloat("PosX"), PlayerPrefs.GetFloat("PosY"), PlayerPrefs.GetFloat("PosZ"));


        if (PlayerPrefs.HasKey("DoubleJumpUnlocked"))
        {
            if(PlayerPrefs.GetInt("DoubleJumpUnlocked") == 1)
            {
                player.canDoubleJump = true;
            }
        }

        if (PlayerPrefs.HasKey("DashUnlocked"))
        {
            if (PlayerPrefs.GetInt("DashUnlocked") == 1)
            {
                player.canDash = true;
            }
        }

        if (PlayerPrefs.HasKey("BallUnlocked"))
        {
            if (PlayerPrefs.GetInt("BallUnlocked") == 1)
            {
                player.canBecomeBall = true;
            }
        }

        if (PlayerPrefs.HasKey("BombUnlocked"))
        {
            if (PlayerPrefs.GetInt("BombUnlocked") == 1)
            {
                player.canDropBomb = true;
            }
        }

        SceneManager.LoadScene(PlayerPrefs.GetString("ContinueLevel"));
    }

    public void QuitGame()
    {
        Application.Quit();

        Debug.Log("Game Quit");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("How to play");
    }

    public void Leaderboard()
    {
        SceneManager.LoadScene("Leaderboard");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");

    }

}
