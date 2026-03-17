using UnityEngine;

public class SetOtherActive : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void changeOtherState(bool state)
    {
        GameObject targetParent = GameObject.Find("Hand Menu");
        GameObject target = targetParent.transform.GetChild (0).gameObject;
        target.SetActive(state);
    }
}
