using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour

   
{
    public InputField playername;
   


   public void PlayGame()
    {
       

        Debug.Log("Player name is: " + playername.text);
        Score.playernamestr = playername.text;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame ()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public Dropdown dropdown;
    public bool check = false;

    public static int StartLife;
    private int droplife;
    public Text lifeText;




    public void Play()
    {
        if (check == false)
        {
            StartLife = 3;
        }
        else
        {
            StartLife = droplife;
        }
        SceneManager.LoadScene(1);
    }

    public void Drop()
    {
        switch (dropdown.value)
        {
            default:
                droplife = 3;
                check = true;
                break;
            case 1:
                droplife = 1;
                check = true;
                break;
            case 2:
                droplife = 2;
                check = true;
                break;
            case 3:
                droplife = 3;
                check = true;
                break;
        }
    }

    void Update()
    {
        lifeText.text = ("LIVES: " + droplife.ToString());
        if (Lives.CurrentLife == 0)
        {
            Lives.CurrentLife = droplife;
        }
    }

   

}


