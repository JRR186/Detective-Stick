using DialogueEditor;
using UnityEngine;

public class ConversationStart : MonoBehaviour
{
    public NPCConversation myConversation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      ConversationManager.Instance.StartConversation(myConversation);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
