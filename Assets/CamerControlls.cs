using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed = 300f;
    public float rotationSpeed = 5f;

    void Update()
    {
        // Movement
        float moveHorizontal = Input.GetAxis("Horizontal"); // "A" and "D" keys
        float moveVertical = Input.GetAxis("Vertical"); // "W" and "S" keys

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        transform.Translate(movement * speed * Time.deltaTime, Space.Self);

        // Rotation
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        float mouseY = -Input.GetAxis("Mouse Y") * rotationSpeed;

        transform.Rotate(mouseY, mouseX, 0);
    }
}
