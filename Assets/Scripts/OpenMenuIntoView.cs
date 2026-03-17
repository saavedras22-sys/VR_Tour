using UnityEngine;

public class OpenMenuIntoView : MonoBehaviour
{
    public float distance = 2; // Distance from the camera
    private bool menuPresent = false;
    private GameObject lastMenuOpened;
    public void OpenMenu(GameObject menuParent)
    {
        if (menuPresent)
        {
            Close(lastMenuOpened);
        }
        GameObject menu = menuParent.transform.GetChild (0).gameObject;
        menu.SetActive(true);
        // Get the camera's position and forward direction
        Transform camTransform = Camera.main.transform;
        
        // Calculate the target position in front of the camera (ignores Y)
        Vector3 forwardFixed = camTransform.forward;
        forwardFixed.y = 0; 
        Vector3 targetPosition = camTransform.position + (forwardFixed.normalized * distance);

        // Instant snap to view
        menu.transform.position = targetPosition;

        menu.transform.LookAt(camTransform);
        menu.transform.Rotate(0, 180, 0); // LookAt points at the back of the menu

        menuPresent = true;
        lastMenuOpened = menu;
    }

    public void CloseMenu(GameObject menuParent)
    {
        GameObject menu = menuParent.transform.GetChild (0).gameObject;
        Close(menu);
    }

    private void Close(GameObject menu)
    {
        menu.SetActive(false);
        menuPresent = false;
    }
}
