using UnityEngine;

public class artertymovement : MonoBehaviour
{
    private bool isDragging = false; // Flag to check if the piece is being dragged
    private Vector3 screenPoint; // The screen position of the object
    private Vector3 offset; // Offset from the object to the mouse cursor

    public Camera mainCamera; // Reference to the camera

    private static artertymovement selectedPiece = null; // Keep track of the selected piece

    void Start()
    {
        // Attempt to find the main camera
        mainCamera = Camera.main;

        if (mainCamera == null)
        {
            Debug.LogError("Main camera not found! Please ensure a camera is tagged as 'MainCamera'.");
        }
    }

    void Update()
    {
        // If we are clicking on a piece, start dragging it
        if (Input.GetMouseButtonDown(0) && !isDragging)
        {
            // Only start dragging if the piece is not already being dragged
            if (selectedPiece == null || selectedPiece != this)  // If it's not already selected
            {
                // If another piece is selected, stop dragging it first
                if (selectedPiece != null)
                {
                    selectedPiece.StopDragging();
                }

                selectedPiece = this; // Set this piece as selected
                StartDragging();
            }
        }

        // While dragging, update the position of the object
        if (Input.GetMouseButton(0) && isDragging)
        {
            DragPiece();
        }

        // Stop dragging when the mouse button is released
        if (Input.GetMouseButtonUp(0) && isDragging)
        {
            StopDragging();
        }
    }

    void StartDragging()
    {
        // Convert the mouse position to world space
        screenPoint = mainCamera.WorldToScreenPoint(transform.position);

        // Calculate the offset between the mouse position and the object's position
        offset = transform.position - mainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

        isDragging = true;
        Debug.Log("Started Dragging: " + gameObject.name);
    }

    void DragPiece()
    {
        // Convert the mouse position to world space
        Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 currentWorldPoint = mainCamera.ScreenToWorldPoint(currentScreenPoint);

        // Update the object’s position based on the mouse position and offset
        transform.position = currentWorldPoint + offset;

        Debug.Log("Dragging: " + gameObject.name + " Position: " + transform.position);
    }

    void StopDragging()
    {
        isDragging = false;
        Debug.Log("Stopped Dragging: " + gameObject.name + " Position: " + transform.position);
    }
}
