using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateGame : MonoBehaviour {

	public void Training()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitGame()
    {
        SceneManager.LoadScene("Setup");
    }
}
