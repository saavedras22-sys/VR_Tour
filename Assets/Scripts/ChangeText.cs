using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ChangeText : MonoBehaviour
{
    private Scene m_Scene;
    private string sceneName;
    private TextMeshProUGUI toChange;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_Scene = SceneManager.GetActiveScene();
        sceneName = m_Scene.name;
        toChange = GetComponent<TextMeshProUGUI>();
        switch(sceneName)
        {
            case "Aula1":
                toChange.text = "Aula 1 - Laboratorio di TLC";
                break;
            case "Aula2":
                toChange.text = "Aula 2 - Laboratorio di Sistemi";
                break;
            case "Aula3":
                toChange.text = "Aula 3 - Laboratorio di Informatica";
                break;
            case "Aula4":
                toChange.text = "Aula 4 - Laboratorio di TPS-IT";
                break;
            case "AulaP8":
                toChange.text = "Aula P8 - Laboratorio";
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
