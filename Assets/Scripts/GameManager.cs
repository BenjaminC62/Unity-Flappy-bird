using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject fadeIn;
    public Player player;
    public Text scoreText;
    public GameObject gameOver;
    public GameObject Re;
    public GameObject Depause;
    private int score;

    void Start() 
    {
        fadeIn.SetActive(true);
    }


    private void Awake()
    {
        Application.targetFrameRate = 60;
        gameOver.SetActive(false);
        Re.SetActive(false);
    }

    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();
        gameOver.SetActive(false);
        Re.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for(int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
        
    }

    public void UnPause()
    {
        Time.timeScale = 1f;
        player.enabled = true;
    }


    public void GameOver()
    {
        gameOver.SetActive(true);
        Re.SetActive(true);
        Pause();
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void Switch()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0); //0 main menu and 1 game
        Play();
    }

    public void Pausa()
    {
        Pause();
    }



}
