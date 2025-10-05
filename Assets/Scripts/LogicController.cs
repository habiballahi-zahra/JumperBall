using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicController : MonoBehaviour
{
    [SerializeField] private GameObject GameOverScreen;
    [SerializeField] public int PlayerScore;
    [SerializeField] public TextMeshProUGUI ScoreText;

    private BallController ballController;
    void Start()
    {
        ballController = GameObject.FindAnyObjectByType<BallController>();
    }
    public void AddScore()
    {
        PlayerScore = PlayerScore + 1;
        ScoreText.text = PlayerScore.ToString();
        Debug.Log("AddScore");
    }

    public void ResetGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        GameOverScreen.SetActive(true);
        ballController.ActiveBall = false;
    }
     public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
