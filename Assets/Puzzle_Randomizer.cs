using UnityEngine;

public class PuzzleRandomizer : MonoBehaviour
{
    public float positionRange = 300.0f; // Range for random position offset
    public Camera mainCamera; // Reference to the main camera
    public Vector3 rotationRange = new Vector3(0, 0, 90); // Limits for rotation randomization

    private void Start()
    {
        if (!mainCamera)
        {
            mainCamera = Camera.main;
        }

        foreach (Transform piece in transform)
        {
            Vector3 randomPosition;

            // Randomize the position within a set range
            do
            {
                randomPosition = new Vector3(
                    Random.Range(-positionRange, positionRange),
                    Random.Range(-positionRange, positionRange),
                 0
                );

                float randomZ = Random.Range(0, 90);

                // Apply the random Z rotation to the current object, keeping the X and Y rotations the same
                piece.rotation = Quaternion.Euler(piece.eulerAngles.x, piece.eulerAngles.y, randomZ);
               

                piece.localPosition += randomPosition;



            } while (!IsInCameraView(piece)); // Keep trying until it's in the camera's view
        }
    }

    private bool IsInCameraView(Transform piece)
    {
        // Get the renderer's bounds to calculate the object's size
        Renderer pieceRenderer = piece.GetComponent<Renderer>();
        if (pieceRenderer == null) return false;

        // Get the object's bounds (the whole object size)
        Bounds pieceBounds = pieceRenderer.bounds;

        // Get the camera's view frustum
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(mainCamera);

        // Check if the object's bounds are fully within the camera's frustum
        return GeometryUtility.TestPlanesAABB(planes, pieceBounds);
    }
}
