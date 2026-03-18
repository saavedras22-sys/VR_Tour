using UnityEngine;

public class SpawnInView : MonoBehaviour
{
    public float distance; // Distance from the camera
    private bool positioned = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        // Get the camera's position and forward direction
        Transform camTransform = Camera.main.transform;
        
        // Calculate the target position in front of the camera (ignores Y)
        Vector3 forwardFixed = camTransform.forward;
        forwardFixed.y = 0; 
        Vector3 targetPosition = camTransform.position + (forwardFixed.normalized * distance);

        // Instant snap to view
        transform.position = targetPosition;

        transform.LookAt(camTransform);
        transform.Rotate(0, 180, 0); // LookAt points at the back of the menu
    }

    // Update is called once per frame
    void Update()
    {/*
        if(!positioned)
        {
            // Get the camera's position and forward direction
            Transform camTransform = Camera.main.transform;
            
            // Calculate the target position in front of the camera (ignores Y)
            Vector3 forwardFixed = camTransform.forward;
            forwardFixed.y = 0; 
            Vector3 targetPosition = camTransform.position + (forwardFixed.normalized * distance);

            // Instant snap to view
            transform.position = targetPosition;

            transform.LookAt(camTransform);
            transform.Rotate(0, 180, 0); // LookAt points at the back of the menu
            positioned = true;
        }*/
    }
}
