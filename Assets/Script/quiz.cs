using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quiz : MonoBehaviour
{
    public void quiz1()
    {
        SceneManager.LoadScene("quiz2");
        score.scoreValue += 1;
    }

    public void quiz2()
    {
        SceneManager.LoadScene("quiz3");
        score.scoreValue += 1;
    }

    public void quiz3()
    {
        SceneManager.LoadScene("quiz4");
        score.scoreValue += 1;
    }

    public void quiz4()
    {
        SceneManager.LoadScene("quiz5");
        score.scoreValue += 1;
    }

    public void quiz5()
    {
        SceneManager.LoadScene("quiz6");
        score.scoreValue += 1;
    }

    public void quiz6()
    {
        SceneManager.LoadScene("quiz7");
        score.scoreValue += 1;
    }

    public void quiz7()
    {
        SceneManager.LoadScene("quiz8");
        score.scoreValue += 1;
    }

    public void quiz8()
    {
        SceneManager.LoadScene("quiz9");
        score.scoreValue += 1;
    }

    public void quiz9()
    {
        SceneManager.LoadScene("quiz10");
        score.scoreValue += 1;
    }

    public void quiz10()
    {
        score.scoreValue += 1;
        SceneManager.LoadScene("quiz11");
    }
}