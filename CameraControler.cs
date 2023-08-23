using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float panSpeed = 10f;                // Speed of the camera movement
    public float panBorderThickness = 10f;      // Distance from the edge of the screen for panning to start
    public float scrollSpeed = 10f;             // Zoom speed
    public float minY = 0.5f;                     // Closest zoom distance
    public float maxY = 10f;                    // Furthest zoom distance
    public Vector2 clampMin = new Vector2(-8,-8);// Minimum camera bounds
    public Vector2 clampMax = new Vector2(8,8);// Maximum camera bounds

    private Vector3 lastPanPosition;
    private int panFingerId; // Touch mode only
    private bool wasDragging;

    void Update()
    {
        Vector3 pos = transform.position;

        // Panning with keys or edge
        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness)
        {
            pos.y += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
        {
            pos.y -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
        {
            pos.x += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness)
        {
            pos.x -= panSpeed * Time.deltaTime;
        }

        // Handle the drag for middle mouse button
        if (Input.GetMouseButtonDown(2))
        {
            
        }
        else if (Input.GetMouseButton(2))
        {
            
        }
        

        // Handle drag for touch input
        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchAvg = (touchZero.position + touchOne.position) / 2;
            if (touchZero.phase == TouchPhase.Began || touchOne.phase == TouchPhase.Began)
            {
                
            }
            else if (touchZero.phase == TouchPhase.Moved || touchOne.phase == TouchPhase.Moved)
            {
                
            }
        }

        // Zooming
        float zoomAmount = Input.GetAxis("Mouse ScrollWheel");
        Camera.main.orthographicSize -= zoomAmount * scrollSpeed;
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, minY, maxY);

        // Clamping position
        pos.x = Mathf.Clamp(pos.x, clampMin.x, clampMax.x);
        pos.y = Mathf.Clamp(pos.y, clampMin.y, clampMax.y);

        transform.position = pos;
    }
}