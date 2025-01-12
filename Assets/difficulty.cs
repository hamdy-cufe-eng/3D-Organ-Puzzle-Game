using UnityEngine;
using TMPro;  // Include this for TextMeshPro

public class CubeButton : MonoBehaviour
{
    public TextMeshProUGUI difficultyText; // Reference to the TextMeshPro UI Text
    private int difficultyLevel = 0; // 0 = Easy, 1 = Normal, 2 = Hard
    public AudioSource audioSource;

    // Difficulty names and their corresponding colors
    private string[] difficultyNames = { "Easy", "Normal", "Hard" };
    private Color[] difficultyColors = { Color.green, Color.yellow, Color.red };

    void OnMouseDown() // Detect when the cube is clicked
    {
        // Cycle to the next difficulty level
        difficultyLevel = (difficultyLevel + 1) % difficultyNames.Length;

        // Update the difficulty text and color
        difficultyText.text = "Difficulty: " + difficultyNames[difficultyLevel];
        difficultyText.color = difficultyColors[difficultyLevel];

        // Play the click sound
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}
