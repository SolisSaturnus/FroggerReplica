
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Frog : MonoBehaviour
{

    public Rigidbody2D rb;





    /*public int level = 3;

    public void SavePlayer ()

    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer ()
    {
       PlayerData data = SaveSystem.LoadPlayer();

        level = data.level;

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;


    }*/

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow))
            rb.MovePosition(rb.position + Vector2.right);
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            rb.MovePosition(rb.position + Vector2.left);
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            rb.MovePosition(rb.position + Vector2.up);
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            rb.MovePosition(rb.position + Vector2.down);

      

        if (Lives.CurrentLife <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Car")
        {
            Debug.Log("WE LOST!");

            Lives.CurrentLife = Lives.CurrentLife - 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);


        }
    }
}

