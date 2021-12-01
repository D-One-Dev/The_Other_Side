using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    //dialogue window GameObject, inventory window GameObject
    [SerializeField] private GameObject dialogueWindow, inventoryWindow;
    //dialogue speed
    [SerializeField] private float dialogueSpeed;
    //dialogue text
    public TMP_Text dialogueText;
    //sentences
    private Queue<string> sentences;
    private void Start()
    {
        sentences = new Queue<string>();
    }
    public void StartDialogue(Dialogue dialogue, GameObject NPC)
    {
        NPC.GetComponent<DialogueTrigger>().currentState = 1;
        inventoryWindow.SetActive(false);
        dialogueWindow.SetActive(true);
        sentences.Clear();
        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextBlock(NPC);
    }
    public void DisplayNextBlock(GameObject NPC)
    {
        if (sentences.Count == 0)
        {
            EndDialogue(NPC);
            return;
        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }
    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            //"!"
            if (letter == (char)33) yield return new WaitForSeconds(dialogueSpeed * 5);
            //","
            else if (letter == (char)44) yield return new WaitForSeconds(dialogueSpeed * 5);
            //"."
            else if (letter == (char)46) yield return new WaitForSeconds(dialogueSpeed * 5);
            //":"
            else if (letter == (char)58) yield return new WaitForSeconds(dialogueSpeed * 5);
            //";"
            else if (letter == (char)59) yield return new WaitForSeconds(dialogueSpeed * 5);
            //" "
            else if (letter == (char)127) yield return new WaitForSeconds(dialogueSpeed * 5);
            else yield return new WaitForSeconds(dialogueSpeed);
        }
    }
    public void EndDialogue(GameObject NPC)
    {
        NPC.GetComponent<DialogueTrigger>().currentState = 0;
        inventoryWindow.SetActive(true);
        dialogueWindow.SetActive(false);
    }
}
