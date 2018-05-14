using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoaderScript : MonoBehaviour {

    const int CAREER = 0;
    const int LEVELS = 1;
    const int EXIT = 3;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void OnBtnClick(int btn)
    {
        switch (btn)
        {
            case LEVELS:
                SceneManager.LoadScene(LEVELS); //levels
                break;
            case CAREER:
                SceneManager.LoadScene(CAREER);
                break;
            case EXIT:
                Application.Quit(); // q
                break;
            default:
                break;
        }
    }
}
