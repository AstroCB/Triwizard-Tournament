using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuActions : MonoBehaviour
{
    public void Restart(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("MazeScene");
    }

    public void Quit(){
        Application.Quit();
    }
}
