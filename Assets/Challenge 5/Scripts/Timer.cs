using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public GameManager gameManager;
    public TextMeshProUGUI timerText;
    public float timeRemaining = 60;

    private void Start()
    {
        gameManager = gameObject.GetComponent<GameManager>();
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            gameManager.GameOver();
        }
    }
}
