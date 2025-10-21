using UnityEngine;
using System.Collections.Generic;
using UnityEditor.Search;
using System;


[Serializable]
public class Inventory_Script : MonoBehaviour
{
    public List<string> items = new List<string>();
    public GameManager gameManager;

    void Start()
    {
        //gameManager = FindAnyObjectByType<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            AddItem("Balls");
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            RemoveItem("Balls");
        }
    }

    void AddItem(string Itemname)
    {
        items.Add(Itemname);
    }
    void RemoveItem(string Itemname)
    {
        items.Remove(Itemname);
    }


}
