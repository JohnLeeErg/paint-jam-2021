using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetButtonUp("Exit"))
        {
            print("quitting");
            Application.Quit();
        }
    }

    public void startGame() {
        SceneManager.LoadScene("johnleeTestScene", LoadSceneMode.Single);
    }

    public void Instructions() {
        SceneManager.LoadScene("Instruction", LoadSceneMode.Single);
    }

    public void ExitGame() {
        Application.Quit();
    }

    public void TitleScreen() {
        SceneManager.LoadScene("FrontPage", LoadSceneMode.Single);
    }
}
