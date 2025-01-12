using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;  // For using coroutines

public class StartPuzzleCube : MonoBehaviour
{
    public AudioSource audioSource;  // Reference to the AudioSource component
    public float delayTime = 1f;    // Delay time (1 second)

    void OnMouseDown()
    {
        // Start the coroutine to add delay and play sound
        StartCoroutine(StartPuzzleWithDelay());
    }

    private IEnumerator StartPuzzleWithDelay()
    {
        // Play the sound on click
        if (audioSource != null)
        {
            audioSource.Play();
        }

        // Wait for the specified delay time (1 second)
        yield return new WaitForSeconds(delayTime);

        // Change the scene after the delay
        SceneManager.LoadScene("latest_pancreas");
    }
}
