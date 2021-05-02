using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{

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
