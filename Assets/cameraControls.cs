using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float moveSpeed = 10f; // Speed of camera movement
    public float rotationSpeed = 100f; // Speed of camera rotation
    public float zoomSpeed = 5f; // Speed of zoom in/out

    private float horizontalInput;
    private float verticalInput;
    private float zoomInput;

    void Update()
    {
        // Handle movement using WASD or arrow keys
        // Move forward and backward based on the forward/backward arrow keys (Up/Down arrows)
        if (Input.GetKey(KeyCode.UpArrow))
        {
            MoveCamera(Vector3.forward); // Move forward along the camera's local z-axis
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            MoveCamera(Vector3.back); // Move backward along the camera's local z-axis
        }

        // Move left and right based on the left/right arrow keys
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            MoveCamera(Vector3.left); // Move left along the camera's local x-axis
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            MoveCamera(Vector3.right); // Move right along the camera's local x-axis
        }

        // Handle mouse look for rotation
        if (Input.GetMouseButton(1)) // Right mouse button for camera rotation
        {
            float rotationX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
            float rotationY = -Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;

            transform.Rotate(Vector3.up, rotationX, Space.World);
            transform.Rotate(Vector3.right, rotationY, Space.Self);
        }

        // Handle zooming in and out using the mouse scroll wheel
        zoomInput = Input.GetAxis("Mouse ScrollWheel");
        if (zoomInput != 0)
        {
            Camera.main.fieldOfView -= zoomInput * zoomSpeed;
            Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, 10, 90); // Set limits for zoom
        }
    }

    // Function to move the camera along its local axes
    void MoveCamera(Vector3 direction)
    {
        // Move the camera based on its local position and the specified direction
        transform.Translate(direction * moveSpeed * Time.deltaTime, Space.Self);
    }
}
