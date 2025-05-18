using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int sceneBuildIndex;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Trigger Entered");

        
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
    }
}