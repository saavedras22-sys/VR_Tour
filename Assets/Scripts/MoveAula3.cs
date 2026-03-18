using UnityEngine;

public class MoveAula3 : MonoBehaviour
{
    public string folderPath = "Aula3/aula_"; 
    private GameObject camera;
    private GameObject buttons_canvas;
    private Material[] skyboxes; 
    private int currentIndex = 0; 
    private GameObject right; 
    private GameObject left; 
    private GameObject father;
    public float distance = 2.0f;
    void Start() { 
        skyboxes = Resources.LoadAll<Material>("Aula3"); 
        if (skyboxes.Length > 0) 
            RenderSettings.skybox = skyboxes[currentIndex]; 
        father = GameObject.Find("Right_Left_Buttons");
        buttons_canvas = GameObject.Find("Buttons2");
        //camera = GameObject.Find("XR Origin (XR Rig)");
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
        if(currentIndex >= 1 && currentIndex < 4) { 
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
