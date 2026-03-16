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
        camera = GameObject.Find("Main Camera");
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
        //Reposition();
    }
    void Reposition()
    {
        switch(currentIndex)
        {
            case 0:
                Reposition_Sky1();
                break;
            case 1:
                Reposition_Sky2();
                break;
            case 2:
                Reposition_Sky3();
                break;
            case 3:
                Reposition_Sky4();
                break;
            case 4:
                Reposition_Sky5();
                break;
        }
    }
    void Reposition_Sky1()
    {
        Transform targetTransform = GameObject.Find("target_1").transform;
        camera.transform.LookAt(targetTransform);
        buttons_canvas.transform.LookAt(targetTransform);
    }
    void Reposition_Sky2()
    {
        buttons_canvas.transform.eulerAngles = new Vector3(
            buttons_canvas.transform.eulerAngles.x,
            buttons_canvas.transform.eulerAngles.y,
            buttons_canvas.transform.eulerAngles.z
        );
        left.transform.eulerAngles = new Vector3(
            left.transform.eulerAngles.x,
            left.transform.eulerAngles.y,
            180.195f
        );
        camera.transform.eulerAngles = new Vector3(0,180,0);
    }
    void Reposition_Sky3()
    {
        buttons_canvas.transform.eulerAngles = new Vector3(90,183.9254f,0);
        left.transform.eulerAngles = new Vector3(-2.14062129e-05f,1.64829362e-05f,0.889403045f);
        camera.transform.eulerAngles = new Vector3(0,185,0);
    }
    void Reposition_Sky4()
    {
        buttons_canvas.transform.eulerAngles = new Vector3(90,94.8505325f,0);
        left.transform.eulerAngles = new Vector3(7.01546651e-06f,1.26773384e-05f,32.0809212f);
        camera.transform.eulerAngles = new Vector3(0,90,0);
    }
    void Reposition_Sky5()
    {
        buttons_canvas.transform.eulerAngles = new Vector3(90,262.925659f,0);
        camera.transform.eulerAngles = new Vector3(0,84.8191147f,0);
    }
}
