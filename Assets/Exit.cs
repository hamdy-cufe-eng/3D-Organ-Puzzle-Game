using UnityEngine;
using System.Collections;  // Include for using IEnumerator and coroutines

public class StopGameCube : MonoBehaviour
{
    public AudioSource audioSource;
    public float delayTime = 0.5f;  // Set the delay time to 1 second

    void OnMouseDown()
    {
        // Start the coroutine that will delay the quit action
        StartCoroutine(QuitWithDelay());
    }

    // Coroutine to delay quitting
    private IEnumerator QuitWithDelay()
    {
        // Optionally, play a sound before quitting
        if (audioSource != null)
        {
            audioSource.Play();
        }

        // Wait for the specified delay time (1 second)
        yield return new WaitForSeconds(delayTime);

        // Quit the application
        Application.Quit();

        // If you're testing in the Unity Editor, use this line to stop Play mode
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
