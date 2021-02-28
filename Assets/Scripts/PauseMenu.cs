using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
            
        }
    }

   public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void LoadMenu()
    {
        Debug.Log("Loading Menu...");

        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void QuitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }

    
}
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{

    GameObject PauseMenu;
    bool paused;
    bool muted;
    [SerializeField]
    Text mutetext;

    void Start()
    {
        paused = false;
        PauseMenu = GameObject.Find("PauseMenu");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
        }

        if (paused)
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0;

        }
        else if (!paused)
        {
            PauseMenu.SetActive(false);
            Time.timeScale = 1;
        }

        if (muted)
        {
            AudioListener.volume = 0;
            mutetext.text = "Unmute";
        }
        else if (!muted)
        {
            AudioListener.volume = 1;
            mutetext.text = "Mute";
        }
    }

    public void Resume()
    {
        paused = false;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Save()
    {
        PlayerPrefs.SetInt("currentscenesave", SceneManager.LoadScene);
    }

    public void Load()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("currentscenesave"));
    }

    public void Mute()
    {
        muted = !muted;
    }

    public void Quit()
    {
        Application.Quit();
    }

}*/