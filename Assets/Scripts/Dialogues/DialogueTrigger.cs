using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    //current stage
    public int currentState;
    //dialogue
    public Dialogue dialogue;
    public void TriggerDialogue()
    {
        if(currentState == 0)
        {
            //starting the dialogue
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue, gameObject);
        }
        else if(currentState == 1)
        {
            //displaying next block of text
            FindObjectOfType<DialogueManager>().DisplayNextBlock(gameObject);
        }
    }
    public void EndDialogue()
    {
        //ending the dialogue
        if(currentState != 0) FindObjectOfType<DialogueManager>().EndDialogue(gameObject);
    }
}
