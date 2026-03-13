using UnityEngine;
using UnityEngine.SceneManagement;
public class GoToAulaScene : MonoBehaviour
{
    public void GoToThisAulaScene(string nextAula)
    {
        SceneManager.LoadScene(nextAula);
    }
}
