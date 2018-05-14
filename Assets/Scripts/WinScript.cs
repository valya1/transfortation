using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        int walked_levels = PlayerPrefs.GetInt("walked_levels");
        PlayerPrefs.SetInt("walked_levels", walked_levels);
        PlayerPrefs.Save();
        SceneManager.LoadScene("Levels");

    }
}
