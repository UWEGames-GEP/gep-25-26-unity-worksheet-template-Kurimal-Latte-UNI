using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUi : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Inventory_Script inventory;
    public List<GameObject> UIbuttons = new List<GameObject>();

   
    private void OnEnable()
    {
        RefreshInventoryUI();

    }
    public void RefreshInventoryUI()
    {
        Debug.Log("Refresh Inventory Ui");
        foreach (GameObject uiButton in UIbuttons)
        {
            uiButton.SetActive(false);
        }
        for (int i = 0; i < inventory.items.Count; i++)
        {
            if (i < UIbuttons.Count)
            {
                InventoryUIButton uiButton = UIbuttons[i].GetComponent<InventoryUIButton>();
                ItemObject item = inventory.items[i];

                uiButton.gameObject.SetActive(true);
                uiButton.Setbutton(item);
            }
        }


    }
    public void OnInventoryUIButton(int i)
    {
        inventory.RemoveItemFromInventory(i);
        RefreshInventoryUI();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
