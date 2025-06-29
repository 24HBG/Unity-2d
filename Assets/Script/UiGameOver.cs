using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UiGameOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    ScoreKeeper scoreKeeper;

    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }
    void Start()
    {
        scoreText.text = "Your Score:\n" + scoreKeeper.GetScore();
    }


}
