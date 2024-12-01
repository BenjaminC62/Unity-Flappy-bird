using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    public GameObject fadeIn;

    void Start()
    {
        fadeIn.SetActive(true);
    }

    public void PlayButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1); //0 main menu and 1 game
    }

}