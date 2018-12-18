using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	public void StartGame()
    {
        SceneManager.LoadScene(1);
    } 

    public void HowToPlay()
    {

    }

    public void Options()
    {

    }

    public void Quit()
    {
        Application.Quit();
    }
}

