using UnityEngine;

public class MoveAula4 : MonoBehaviour
{
    public string folderPath = "Aula4/aula_"; 
    private Material[] skyboxes; 
    private int currentIndex = 0; 
    private GameObject right; 
    private GameObject left; 
    private GameObject father;
    void Start() { 
        skyboxes = Resources.LoadAll<Material>("Aula4"); 
        if (skyboxes.Length > 0) 
            RenderSettings.skybox = skyboxes[currentIndex]; 
        father = GameObject.Find("Right_Left_Buttons");
        right = father.transform.GetChild (0).gameObject;
        left = father.transform.GetChild (1).gameObject;
        if(currentIndex == 0) { 
            left.SetActive(false); 
        } 
    } 
    public void NextSkybox() {
        currentIndex = (currentIndex + 1) % skyboxes.Length; 
        UpdateSkybox(); 
    } 
    public void PreviousSkybox() { 
        currentIndex--; 
        if (currentIndex <= 0) { 
            left.SetActive(false); 
        } 
        UpdateSkybox(); 
    } 
    void UpdateSkybox() { 
        right = father.transform.GetChild (0).gameObject;
        left = father.transform.GetChild (1).gameObject;
        RenderSettings.skybox = skyboxes[currentIndex]; 
        DynamicGI.UpdateEnvironment(); 
        if(currentIndex == 1) { 
            right.SetActive(true); 
            left.SetActive(true); 
        } else if(currentIndex < 1)
        {
            right.SetActive(true);
            left.SetActive(false);
        } else
        {
            right.SetActive(false);
            left.SetActive(true);
        }
    }
}
