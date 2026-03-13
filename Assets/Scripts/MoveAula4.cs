using UnityEngine;

public class MoveAula4 : MonoBehaviour
{
    public string folderPath = "Aula4/aula_";
    private Material[] skyboxes;
    private int currentIndex = 0;

    void Start()
    {
        skyboxes = Resources.LoadAll<Material>("Aula4");
        
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
