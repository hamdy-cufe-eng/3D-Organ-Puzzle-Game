using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public float timeRemaining = 60f; // Set your timer duration here
    public Text timerText;            // Attach a UI Text element to display the timer
    public GameObject gameOverPanel;  // Attach a UI Panel or Text for "Game Over" message

    void Start()
    {
        gameOverPanel.SetActive(false); // Hide Game Over message initially
        if (timerText == null)
        {
            timerText = GameObject.Find("TimerText").GetComponent<Text>(); // Replace "TimerText" with the actual name of your UI Text element
        }
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            DisplayTime(timeRemaining);
        }
        else
        {
            EndGame();
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void EndGame()
    {
        timeRemaining = 0;
        gameOverPanel.SetActive(true);  // Display the Game Over message
    }
}
