using UnityEngine;
using UnityEngine.UI;

public class CursorController : MonoBehaviour
{
    //cursor image
    [SerializeField] private Image cursor;
    //cursor sprites
    [SerializeField] private Sprite defaultIcon, talkIcon, pickIcon;
    //look target
    private GameObject lookTarget;

    //controls
    private Controls controls;
    private void Awake()
    {
        controls = new Controls();
        controls.Player.Interact.performed += context => Interact();

    }
    private void OnEnable()
    { controls.Enable(); }
    private void OnDisable()
    { controls.Disable(); }
    private void Interact()
    {
        //interaction vith NPCs
        if (lookTarget.CompareTag("NPC"))
        {
            lookTarget.GetComponent<DialogueTrigger>().TriggerDialogue();
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        //changing cursor sprite
        if (lookTarget != collision.gameObject)
        {
            lookTarget = collision.gameObject;
            if (collision.gameObject.CompareTag("NPC")) cursor.sprite = talkIcon;
            else if (collision.gameObject.CompareTag("Item")) cursor.sprite = pickIcon;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        //ending the dialog
        if (collision.gameObject.CompareTag("NPC") && lookTarget.GetComponent<DialogueTrigger>() != null) lookTarget.GetComponent<DialogueTrigger>().EndDialogue();
        lookTarget = null;
        //changing cursor sprite
        cursor.sprite = defaultIcon;
    }
}
