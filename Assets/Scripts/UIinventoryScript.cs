using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class UIinventoryScript : MonoBehaviour
{
    public UIinventoryScript inventory;
    public List<GameObject> inventoryUIButtons = new List<GameObject>();

    private void OnEnable()
    {
        RefreshInventory();
    }

    void RefreshInventory()
    {
        Debug.Log("Refresh Inventory UI");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
}
