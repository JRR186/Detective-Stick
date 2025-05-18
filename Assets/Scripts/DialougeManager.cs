using System.Collections;
using JetBrains.Annotations;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DialougeManager : MonoBehaviour
{
    [SerializeField] private float typingspeed = 0.05f;

    [SerializeField] private TextMeshProUGUI playerdialougetext;
    [SerializeField] private TextMeshProUGUI npcdialougetext;

    [SerializeField] private string[] playersentence;
    [SerializeField] private string[] npcsentence;

    [SerializeField] private GameObject playercontinuebutton;
    [SerializeField] private GameObject npccontinuebutton;

    private int playerindex;
    private int npcindex;


    public void Start()
    {
        //if (playerspeakingfirst)
        {
        //    StartCoroutine(playertypedialouge)
        }
       // StartCoroutine(typedialouge());
    }
    private IEnumerator typedialouge()
    {
        foreach (char letter in playersentence[playerindex].ToCharArray())
        {
            playerdialougetext.text += letter;
            yield return new WaitForSeconds(typingspeed);
        }
    }
   // public void ContinuePlayerDialouge()
   // {
      //  if (playerindex < playersentence.Length - 1)
       // {
       //     playerindex++;
       //     playerdialougetext.text = string.Empty;
     //       StartCoroutine(playertypedialouge());
        //}
    //}
}
