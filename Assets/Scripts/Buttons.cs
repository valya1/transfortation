using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

    public void PlayPressed()
    {
        SceneManager.LoadScene("Levels");
    }

    public void ExitPressed()
    {
        Application.Quit();
    }

    public void BackPressed()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void SelectLevel(int number)
    {
        SceneManager.LoadScene(1+number);
    }
}
