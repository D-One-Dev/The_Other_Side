using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour
{
    //items sprites
    [SerializeField] private List<Image> itemSprites;
    //items objects
    [SerializeField] private List<GameObject> itemObjects;
    //current item
    private int currentItem;

    //controls
    private Controls controls;
    private void Awake()
    {
        controls = new Controls();
        controls.Player.ChangeItemLeft.performed += context => ChangeItemLeft();
        controls.Player.ChangeItemRight.performed += context => ChangeItemRight();
    }
    private void OnEnable()
    { controls.Enable(); }
    private void OnDisable()
    { controls.Disable(); }
    private void Start()
    {
        ChangeItem(true);
    }
    private void ChangeItemLeft()
    {
        ChangeItem(false);
        if (currentItem > 0) currentItem--;
        else currentItem = itemSprites.Count - 1;
        ChangeItem(true);
    }
    private void ChangeItemRight()
    {
        ChangeItem(false);
        if (currentItem < itemSprites.Count - 1) currentItem++;
        else currentItem = 0;
        ChangeItem(true);
    }
    private void ChangeItem(bool status)
    {
        itemSprites[currentItem].GetComponent<Outline>().enabled = status;
        itemObjects[currentItem].SetActive(status);
    }
}
