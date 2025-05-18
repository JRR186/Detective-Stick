using UnityEngine;
using TMPro;

public class ChatBubble : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private SpriteRenderer backsprite;
    private TextMeshPro textmesh;
    private void Awake()
    {
        backsprite = transform.Find("Background").GetComponent<SpriteRenderer>();
        textmesh = transform.Find("Text").GetComponent < TextMeshPro>();
    }
    private void Start() {
        Setup("Hello World");
    }

    private void Setup(string text) {
        textmesh.SetText(text);
        textmesh.ForceMeshUpdate();
        Vector2 textsize = textmesh.GetRenderedValues(false);
        Vector2 padding = new Vector2(7f, 2f);
        backsprite.size = textsize + padding;
    }
}