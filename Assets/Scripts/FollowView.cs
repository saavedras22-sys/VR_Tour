using UnityEngine;

public class FollowView : MonoBehaviour
{
    public float distance = 2.0f; // Distance from the camera
    public float smoothSpeed = 5.0f; // Speed of following

    void Update()
    {
        MoveIntoView();
    }

   /* void MoveIntoView()
    {
        // Get the camera's position and forward direction
        Transform camTransform = Camera.main.transform;
        
        // Calculate the target position in front of the camera
        Vector3 targetPosition = camTransform.position + camTransform.forward * distance;

        // Option A: Instant snap to view
        // transform.position = targetPosition;

        // Option B: Smoothly follow (better for UI/floating objects)
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * smoothSpeed);

        // Keep the object facing the camera
        transform.rotation = camTransform.rotation;
        
    }*/
    void MoveIntoView()
    {
        // Get the camera's position and forward direction
        Transform camTransform = Camera.main.transform;
        
        // Calculate the target position in front of the camera
        Vector3 targetPosition = camTransform.position + camTransform.forward * distance;

        targetPosition.y = 0.6f;
        targetPosition.x += 0.2f;
        targetPosition.y += 0.2f;
        // Option A: Instant snap to view
        // transform.position = targetPosition;

        // Option B: Smoothly follow (better for UI/floating objects)
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * smoothSpeed);

        
    }
}
