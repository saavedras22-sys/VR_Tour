using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime;
    private bool buttonClicked = false;
    private string scene;
    void Update()
    {
        if(buttonClicked)
        {
            Load();
        }
    }
    public void click(bool clicked)
    {
        buttonClicked = clicked;
    }
    public void setScene(string s)
    {
        scene = s;
    }
    public void Load()
    {
        StartCoroutine(LoadLevel());
    }
    IEnumerator LoadLevel()
    {
        transition.SetTrigger("End");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(scene);
        
    }
}
