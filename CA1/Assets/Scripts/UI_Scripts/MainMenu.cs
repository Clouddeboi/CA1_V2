using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Learned how to make main menu here:https://www.youtube.com/watch?v=DX7HyN7oJjE&t=269s 
    //And also learned how to make the buttons from flappy bird game which me worked on in class
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
