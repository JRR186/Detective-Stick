using UnityEngine;

public class MobileControls : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.SetActive(Application.isMobilePlatform);
    }
}