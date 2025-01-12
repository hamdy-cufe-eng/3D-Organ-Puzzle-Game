using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
public class Timer : MonoBehaviour
{
    public float timeRemaining = 90f;
    [SerializeField]TextMeshProUGUI timerText;
    public GameObject gameOverPanel;
    public float gameOverDelay = 3f;

    void Start()
    {
      
        gameOverPanel.SetActive(false);
    }

    public void StopTimer()
    {
        timeRemaining = -10;
        Debug.Log("Timer stopped");
    }
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            DisplayTime(timeRemaining);
            Debug.Log("Timer updating: " + timeRemaining); // For debugging
        }
        else if(timeRemaining < 0 && timeRemaining >-10 )
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
        timerText.text = "Game Over";
        gameOverPanel.SetActive(true);
        Debug.Log("Game Over"); // For debugging

        StartCoroutine(CloseGameAfterDelay());
    }

    IEnumerator CloseGameAfterDelay()
    {
        yield return new WaitForSeconds(gameOverDelay);  // Wait for the specified delay
        Application.Quit();                              // Close the game window

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Stop playing in the editor
#endif
    }
}
