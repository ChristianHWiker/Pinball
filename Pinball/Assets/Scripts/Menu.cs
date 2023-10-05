using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

   public void playGame()
    {
        SceneManager.LoadScene("PinballScene");
    }

    public void quitFunc()
    {
        Application.Quit();
    }
}