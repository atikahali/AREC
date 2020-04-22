using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{

    public void Enter()
    {
        SceneManager.LoadScene("menu");
    }

    public void Scan()
    {
        SceneManager.LoadScene("scan");
    }

    public void Quiz()
    {
        SceneManager.LoadScene("quiz1");
    }
}
