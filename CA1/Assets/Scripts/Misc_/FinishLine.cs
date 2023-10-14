using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    //video followed: https://www.youtube.com/watch?v=Q90cUrm4LYo&ab_channel=HackingtonsCodeSchool 

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")//if object collided is tagged as player
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Time.timeScale = 1;
        }
    }
}
