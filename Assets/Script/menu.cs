using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{

    public void Comic()
    {
        SceneManager.LoadScene("scanMenu");
    }

    public void Quiz()
    {
        SceneManager.LoadScene("quizMenu");

    }

    public void Exit()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
