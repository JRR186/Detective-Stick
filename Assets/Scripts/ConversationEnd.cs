using DialogueEditor;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ConversationEnd : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Repeat()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
