using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LogicController : MonoBehaviour
{
    [SerializeField] public int PlayerScore;
    [SerializeField] public TextMeshProUGUI  ScoreText;

    public void AddScore()
    {
        PlayerScore = PlayerScore + 1;
        ScoreText.text = PlayerScore.ToString();
        Debug.Log("AddScore");
    }
}
