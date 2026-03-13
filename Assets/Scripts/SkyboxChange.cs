using UnityEngine;

public class SkyboxChange : MonoBehaviour
{
    public string folderPath = "Skyboxes/Sky_";
    private Material[] skyboxes;
    private int currentIndex = 0;

    void Start()
    {
        skyboxes = Resources.LoadAll<Material>("Skyboxes");
        
        if (skyboxes.Length > 0)
            RenderSettings.skybox = skyboxes[currentIndex];
    }

    public void NextSkybox()
    {
        currentIndex = (currentIndex + 1) % skyboxes.Length;
        UpdateSkybox();
    }

    public void PreviousSkybox()
    {
        currentIndex--;
        if (currentIndex < 0) currentIndex = skyboxes.Length - 1;
        UpdateSkybox();
    }

    void UpdateSkybox()
    {
        RenderSettings.skybox = skyboxes[currentIndex];
        DynamicGI.UpdateEnvironment(); 
    }
}
