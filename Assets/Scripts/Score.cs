
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int CurrentScore = 0;

    public static string playernamestr;

    public Text playername;

    public Text scoreText;

  

    void Start ()
    {
        playername.text = playernamestr;

        scoreText.text = CurrentScore.ToString();
    }
}
