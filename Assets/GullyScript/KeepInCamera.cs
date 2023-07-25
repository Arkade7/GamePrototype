using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepInCamera : MonoBehaviour
{
    private Camera mainCamera;
    private float objectWidth;
    private float objectHeight;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;

        // Get the size of the object
        objectWidth = GetComponent<Renderer>().bounds.size.x;
        objectHeight = GetComponent<Renderer>().bounds.size.y;
    }

    // Update is called once per frame
    void Update()
    {
        // Convert the object's position from world space to viewport space
        Vector3 viewportPosition = mainCamera.WorldToViewportPoint(transform.position);

        // Check if the object's viewport position is outside the range of (0,0) to (1,1)
        if (viewportPosition.x < 0 || viewportPosition.x > 1 || viewportPosition.y < 0 || viewportPosition.y > 1)
        {
            // Reposition the object to the edge of the screen
            float newX = Mathf.Clamp(viewportPosition.x, 0.5f, 0.5f);
            float newY = Mathf.Clamp(viewportPosition.y, 0.5f, 0.5f);
            transform.position = mainCamera.ViewportToWorldPoint(new Vector3(newX, newY, viewportPosition.z));
        }
    }

    // Draw gizmos to show the object's size in the scene view
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(transform.position, new Vector3(objectWidth, objectHeight, 0));
    }
}

