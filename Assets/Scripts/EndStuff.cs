using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndStuff : MonoBehaviour
{
    public static int endscore = Score.CurrentScore;
    public static int endlives = Lives.CurrentLife;
    public Text end;
    public Text endlife;


    /*public void Stats ()
    {
        end.text = ("SCORE: " + endscore.ToString());
        endlife.text = ("Lives: " + endlives.ToString());
    }*/

    public void LoadBeginning()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }
}

