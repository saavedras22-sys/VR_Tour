using UnityEngine;
using TMPro;

public class GoToAula : MonoBehaviour
{
    public string folderPath = "Skyboxes/Sky_";
    private Material[] skyboxes;
    private Material skybox;
    void Start()
    {
        skyboxes = Resources.LoadAll<Material>("Skyboxes");
    }

    public void goToThisAula(int aulaIndex)
    {
        skybox = skyboxes[aulaIndex - 1];
        RenderSettings.skybox = skybox;
        DynamicGI.UpdateEnvironment(); 
    }
}
