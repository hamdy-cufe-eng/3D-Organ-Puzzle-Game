using UnityEngine;
using System.Collections;
using TMPro;
public class PuzzlePieceController : MonoBehaviour
{
    private bool isDragging = false; // Flag to check if the piece is being dragged
    private Vector3 screenPoint; // The screen position of the object
    private Vector3 offset; // Offset from the object to the mouse cursor
    private Camera mainCamera; // Reference to the camera
    private static PuzzlePieceController selectedPiece = null; // Track the selected piece
    public float rotationSpeed = 30f; // Rotation speed, adjust to your needs
    public GameObject gameOverPanel;
    public TextMeshProUGUI timerText;
    public Timer timerScript;
    void Start()
    {
        // Get the main camera
        mainCamera = Camera.main;

        if (mainCamera == null)
        {
            Debug.LogError("Main camera not found! Please ensure a camera is tagged as 'MainCamera'.");
        }
    }
  
    void Snapping()
    {

        #region dodenum
      
        
        GameObject target_dodenum = GameObject.Find("dodenum");
        GameObject transparent_dodenum = GameObject.Find("dodenum_trans");

            // Check if the object was found
            if (target_dodenum != null)
            {
                // Get the position of the object

                Vector3 targetPosition = target_dodenum.transform.position;
                Vector3 transPosition = transparent_dodenum.transform.position;

                Quaternion transrotation = transparent_dodenum.transform.rotation;


                Debug.Log("Position of " + "dodenum" + ": " + targetPosition);
                Debug.Log("Position of " + "trans_dodenum" + ": " + transPosition);

                Vector2 targetPositionXY = new Vector2(target_dodenum.transform.position.x, target_dodenum.transform.position.y);
                Vector2 referencePositionXY = new Vector2(transparent_dodenum.transform.position.x, transparent_dodenum.transform.position.y);
                float distanceXY = Vector2.Distance(targetPositionXY, referencePositionXY);

                Debug.Log("distance differance :" + distanceXY);
                if (distanceXY <= 30.0)
                {
                    // Set target object's position if within range (only X and Y are updated)
                    target_dodenum.transform.position = new Vector3(transPosition.x, transPosition.y, transPosition.z);
                    target_dodenum.transform.rotation =  Quaternion.Euler(transparent_dodenum.transform.eulerAngles.x, transparent_dodenum.transform.eulerAngles.y, transparent_dodenum.transform.eulerAngles.z);

                    Debug.Log("Target object within range on X and Y. Position set to: " + transPosition);
                    
                }

            }


        
        #endregion


        #region artery
        GameObject target_artery = GameObject.Find("artery");
        GameObject transparent_artery = GameObject.Find("artery_trans");

        // Check if the object was found
        if (target_artery != null)
        {
            // Get the position of the object

            Vector3 targetPosition = target_artery.transform.position;
            Vector3 transPosition = transparent_artery.transform.position;



            Debug.Log("Position of " + "artery" + ": " + targetPosition);
            Debug.Log("Position of " + "trans_artery" + ": " + transPosition);

            Vector2 targetPositionXY = new Vector2(target_artery.transform.position.x, target_artery.transform.position.y);
            Vector2 referencePositionXY = new Vector2(transparent_artery.transform.position.x, transparent_artery.transform.position.y);
            float distanceXY = Vector2.Distance(targetPositionXY, referencePositionXY);

            Debug.Log("distance differance :" + distanceXY);
            if (distanceXY <= 30.0)
            {
                // Set target object's position if within range (only X and Y are updated)
                target_artery.transform.position = new Vector3(transPosition.x, transPosition.y, transPosition.z);
                target_artery.transform.rotation = Quaternion.Euler(transparent_artery.transform.eulerAngles.x, transparent_artery.transform.eulerAngles.y, transparent_artery.transform.eulerAngles.z);

                Debug.Log("Target object within range on X and Y. Position set to: " + transPosition);
            }




        }
        #endregion


        #region vein1
        GameObject target_vein1 = GameObject.Find("vein1");
        GameObject transparent_vein1 = GameObject.Find("vein1_trans");

        // Check if the object was found
        if (target_vein1 != null)
        {
            // Get the position of the object

            Vector3 targetPosition = target_vein1.transform.position;
            Vector3 transPosition = transparent_vein1.transform.position;



            Debug.Log("Position of " + "vein1" + ": " + targetPosition);
            Debug.Log("Position of " + "trans_vein1" + ": " + transPosition);

            Vector2 targetPositionXY = new Vector2(target_vein1.transform.position.x, target_vein1.transform.position.y);
            Vector2 referencePositionXY = new Vector2(transparent_vein1.transform.position.x, transparent_vein1.transform.position.y);
            float distanceXY = Vector2.Distance(targetPositionXY, referencePositionXY);

            Debug.Log("distance differance :" + distanceXY);
            if (distanceXY <= 30.0)
            {
                // Set target object's position if within range (only X and Y are updated)
                target_vein1.transform.position = new Vector3(transPosition.x, transPosition.y, transPosition.z);
                target_vein1.transform.rotation = Quaternion.Euler(transparent_vein1.transform.eulerAngles.x, transparent_vein1.transform.eulerAngles.y, transparent_vein1.transform.eulerAngles.z);

                Debug.Log("Target object within range on X and Y. Position set to: " + transPosition);
            }




        }
        #endregion


        #region vein2
        GameObject target_vein2 = GameObject.Find("vein2");
        GameObject transparent_vein2 = GameObject.Find("vein2_trans");

        // Check if the object was found
        if (target_vein2 != null)
        {
            // Get the position of the object

            Vector3 targetPosition = target_vein2.transform.position;
            Vector3 transPosition = transparent_vein2.transform.position;



            Debug.Log("Position of " + "vein2" + ": " + targetPosition);
            Debug.Log("Position of " + "trans_vein2" + ": " + transPosition);

            Vector2 targetPositionXY = new Vector2(target_vein2.transform.position.x, target_vein2.transform.position.y);
            Vector2 referencePositionXY = new Vector2(transparent_vein2.transform.position.x, transparent_vein2.transform.position.y);
            float distanceXY = Vector2.Distance(targetPositionXY, referencePositionXY);

            Debug.Log("distance differance :" + distanceXY);
            if (distanceXY <= 30.0)
            {
                // Set target object's position if within range (only X and Y are updated)
                target_vein2.transform.position = new Vector3(transPosition.x, transPosition.y, transPosition.z);
                target_vein2.transform.rotation = Quaternion.Euler(transparent_vein2.transform.eulerAngles.x, transparent_vein2.transform.eulerAngles.y, transparent_vein2.transform.eulerAngles.z);

                Debug.Log("Target object within range on X and Y. Position set to: " + transPosition);
            }




        }
        #endregion

        #region part1
        GameObject target_part1 = GameObject.Find("part1");
        GameObject transparent_part1 = GameObject.Find("part1_trans");

        // Check if the object was found
        if (target_part1 != null)
        {
            // Get the position of the object

            Vector3 targetPosition = target_part1.transform.position;
            Vector3 transPosition = transparent_part1.transform.position;



            Debug.Log("Position of " + "part1" + ": " + targetPosition);
            Debug.Log("Position of " + "trans_part1" + ": " + transPosition);

            Vector2 targetPositionXY = new Vector2(target_part1.transform.position.x, target_part1.transform.position.y);
            Vector2 referencePositionXY = new Vector2(transparent_part1.transform.position.x, transparent_part1.transform.position.y);
            float distanceXY = Vector2.Distance(targetPositionXY, referencePositionXY);

            Debug.Log("distance differance :" + distanceXY);
            if (distanceXY <= 30.0)
            {
                // Set target object's position if within range (only X and Y are updated)
                target_part1.transform.position = new Vector3(transPosition.x, transPosition.y, transPosition.z);
                target_part1.transform.rotation = Quaternion.Euler(transparent_part1.transform.eulerAngles.x, transparent_part1.transform.eulerAngles.y, transparent_part1.transform.eulerAngles.z);
                Debug.Log("Target object within range on X and Y. Position set to: " + transPosition);
            }




        }
        #endregion


        #region part2
        GameObject target_part2 = GameObject.Find("part2");
        GameObject transparent_part2 = GameObject.Find("part2_trans");

        // Check if the object was found
        if (target_part2 != null)
        {
            // Get the position of the object

            Vector3 targetPosition = target_part2.transform.position;
            Vector3 transPosition = transparent_part2.transform.position;



            Debug.Log("Position of " + "part2" + ": " + targetPosition);
            Debug.Log("Position of " + "trans_part2" + ": " + transPosition);

            Vector2 targetPositionXY = new Vector2(target_part2.transform.position.x, target_part2.transform.position.y);
            Vector2 referencePositionXY = new Vector2(transparent_part2.transform.position.x, transparent_part2.transform.position.y);
            float distanceXY = Vector2.Distance(targetPositionXY, referencePositionXY);

            Debug.Log("distance differance :" + distanceXY);
            if (distanceXY <= 30.0)
            {
                // Set target object's position if within range (only X and Y are updated)
                target_part2.transform.position = new Vector3(transPosition.x, transPosition.y, transPosition.z);
                target_part2.transform.rotation = Quaternion.Euler(transparent_part2.transform.eulerAngles.x, transparent_part2.transform.eulerAngles.y, transparent_part2.transform.eulerAngles.z);

                Debug.Log("Target object within range on X and Y. Position set to: " + transPosition);
            }




        }
        #endregion


        #region part3
        GameObject target_part3 = GameObject.Find("part3");
        GameObject transparent_part3 = GameObject.Find("part3_trans");

        // Check if the object was found
        if (target_part3 != null)
        {
            // Get the position of the object

            Vector3 targetPosition = target_part3.transform.position;
            Vector3 transPosition = transparent_part3.transform.position;



            Debug.Log("Position of " + "part3" + ": " + targetPosition);
            Debug.Log("Position of " + "trans_part3" + ": " + transPosition);

            Vector2 targetPositionXY = new Vector2(target_part3.transform.position.x, target_part3.transform.position.y);
            Vector2 referencePositionXY = new Vector2(transparent_part3.transform.position.x, transparent_part3.transform.position.y);
            float distanceXY = Vector2.Distance(targetPositionXY, referencePositionXY);

            Debug.Log("distance differance :" + distanceXY);
            if (distanceXY <= 30.0)
            {
                // Set target object's position if within range (only X and Y are updated)
                target_part3.transform.position = new Vector3(transPosition.x, transPosition.y, transPosition.z);
                target_part3.transform.rotation = Quaternion.Euler(transparent_part3.transform.eulerAngles.x, transparent_part3.transform.eulerAngles.y, transparent_part3.transform.eulerAngles.z);

                Debug.Log("Target object within range on X and Y. Position set to: " + transPosition);
            }




        }
        #endregion


        #region part4
        GameObject target_part4 = GameObject.Find("part4");
        GameObject transparent_part4 = GameObject.Find("part4_trans");

        // Check if the object was found
        if (target_part4 != null)
        {
            // Get the position of the object

            Vector3 targetPosition = target_part4.transform.position;
            Vector3 transPosition = transparent_part4.transform.position;



            Debug.Log("Position of " + "part4" + ": " + targetPosition);
            Debug.Log("Position of " + "trans_part4" + ": " + transPosition);

            Vector2 targetPositionXY = new Vector2(target_part4.transform.position.x, target_part4.transform.position.y);
            Vector2 referencePositionXY = new Vector2(transparent_part4.transform.position.x, transparent_part4.transform.position.y);
            float distanceXY = Vector2.Distance(targetPositionXY, referencePositionXY);

            Debug.Log("distance differance :" + distanceXY);
            if (distanceXY <= 30.0)
            {
                // Set target object's position if within range (only X and Y are updated)
                target_part4.transform.position = new Vector3(transPosition.x, transPosition.y, transPosition.z);
                target_part4.transform.rotation = Quaternion.Euler(transparent_part4.transform.eulerAngles.x, transparent_part4.transform.eulerAngles.y, transparent_part4.transform.eulerAngles.z);

                Debug.Log("Target object within range on X and Y. Position set to: " + transPosition);
            }




        }
        #endregion

        if(target_part4.transform.position == transparent_part4.transform.position &&
            target_part4.transform.rotation == transparent_part4.transform.rotation &&

            target_part3.transform.position == transparent_part3.transform.position &&
            target_part3.transform.rotation == transparent_part3.transform.rotation &&

            target_part2.transform.position == transparent_part2.transform.position &&
            target_part2.transform.rotation == transparent_part2.transform.rotation &&

            target_part1.transform.position == transparent_part1.transform.position &&
            target_part1.transform.rotation == transparent_part1.transform.rotation &&

            target_vein2.transform.position == transparent_vein2.transform.position &&
            target_vein2.transform.rotation == transparent_vein2.transform.rotation &&

            target_vein1.transform.position == transparent_vein1.transform.position &&
            target_vein1.transform.rotation == transparent_vein1.transform.rotation &&

            target_artery.transform.position == transparent_artery.transform.position &&
            target_artery.transform.rotation == transparent_artery.transform.rotation &&

            target_dodenum.transform.position == transparent_dodenum.transform.position &&
            target_dodenum.transform.rotation == transparent_dodenum.transform.rotation 

            )
        {

            timerScript.StopTimer();
           
            Debug.Log("You Win "); // For debugging

            StartCoroutine(EndTimer());
        }
        IEnumerator EndTimer()
        {
            yield return new WaitForSeconds(7f);  // Wait for the specified delay

            timerText.text = "YOUUU WIIIIIN";
            timerText.color = Color.green;
            gameOverPanel.SetActive(true);
            StartCoroutine(CloseGameAfterDelay());// Close the game window

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Stop playing in the editor
#endif
        }
        IEnumerator CloseGameAfterDelay()
        {
            yield return new WaitForSeconds(15f);  // Wait for the specified delay
            Application.Quit();                              // Close the game window

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Stop playing in the editor
#endif
        }
    }
    

    void Update()
    {
        Snapping();
        // Check for mouse click
        if (Input.GetMouseButtonDown(0))
        {
            // Check if the piece is clicked
            if (IsMouseOverPiece())
            {
                //// If a piece is already selected, stop dragging the rest
                if (selectedPiece != null && selectedPiece != this)
                {
                    selectedPiece.StopDragging();
                }

                // Select the current piece to start dragging
                selectedPiece = this;
                StartDragging();
            }
        }

        // If a piece is selected and mouse button is held down, drag the piece
        if (Input.GetMouseButton(0) && isDragging)
        {
            DragPiece();
        }

        // If mouse button is released, stop dragging
        if (Input.GetMouseButtonUp(0) && isDragging)
        {
            StopDragging();
        }
    }

    bool IsMouseOverPiece()
    {
        // Cast a ray from the camera to the mouse position and check if it hits the current object
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            // If the ray hits the object, return true
            if (hit.collider.gameObject == gameObject)
            {
                return true;
            }
        }

        return false;
    }

    void StartDragging()
    {
         
      

        // Convert the mouse position to world space

        screenPoint = mainCamera.WorldToScreenPoint(transform.position);
       
        // Calculate the offset between the mouse position and the object's position
        offset = transform.position - mainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

        isDragging = true;
    }

    void DragPiece()
    {
        // Convert the mouse position to world space
        Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 currentWorldPoint = mainCamera.ScreenToWorldPoint(currentScreenPoint);

        // Update the object’s position based on the mouse position and offset
        transform.position = currentWorldPoint ;
        

        // Optional: You can add additional keys for other axes or rotations
        // Rotate along Z-axis
        if (Input.GetKey(KeyCode.Q)) // Rotate counterclockwise along Z-axis (Q)
        {
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.E)) // Rotate clockwise along Z-axis (E)
        {
            transform.Rotate(-Vector3.forward * rotationSpeed * Time.deltaTime);
        }
    }

    void StopDragging()
    {
        // Stop dragging the piece and reset the state
        isDragging = false;
        selectedPiece = null; // Deselect the piece
    }
}
