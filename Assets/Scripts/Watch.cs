using UnityEngine;
using UnityEngine.UI;

public class Watch : MonoBehaviour
{
    public GameObject watchUI;  // Reference to the UI item you want to show/hide (e.g., an image or icon)
    public string interactButton = "e";  // The key used to interact (default is "e")

    public bool watchOn = false;  // Tracks if the item is visible or not

    private void Start()
    {
        watchUI.SetActive(watchOn);
    }
    void Update()
    {
        // Check if the "E" key is pressed
        if (Input.GetKeyDown(KeyCode.E))
        {
            ToggleWatchUI();
        }
    }

   public void ToggleWatchUI()
    {
        // Toggle the visibility of the UI item
        watchOn = !watchOn;

        // Set the UI item to be active or inactive based on the itemVisible state
        watchUI.SetActive(watchOn);
    }
}
