using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ChangeScenes : MonoBehaviour
{
    public void GoToScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
