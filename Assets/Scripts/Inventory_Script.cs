using UnityEngine;
using System.Collections.Generic;
using UnityEditor.Search;
using System;


[Serializable]
public class Inventory_Script : MonoBehaviour
{
    public List<ItemObject> items = new List<ItemObject>();
    public GameManager gameManager;
    Transform worldItemsTransform;


    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        worldItemsTransform = GameObject.Find("WorldItems").transform;
    }

    // Update is called once per frame
    void Update()
    {
        /*   if (Input.GetKeyDown(KeyCode.N))
           {
               AddItem("Balls");
           }
           if (Input.GetKeyDown(KeyCode.B))
           {
               RemoveItem("Balls");
          } */
    }

    void AddItem(ItemObject Itemname)
    {

        items.Add(Itemname);
    }
    void RemoveItem(ItemObject Itemname)
    {
        items.Remove(Itemname);
    }


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log(hit.gameObject.name);
        ItemObject collisionItem = hit.gameObject.GetComponent<ItemObject>();

        if (collisionItem != null)
        {
            items.Add(collisionItem);
        }

        collisionItem.gameObject.SetActive(false);
    }

    public void AddItemToInventory(ItemObject item)
    {
        items.Add(item);
    }

    public void RemoveItemFromInventory(ItemObject item)
    {
        items.Remove(item);
    }
    
    public void RemoveItemFromInventory()
    {
        if (gameManager.state == GameManager.GameState.GAMEPLAY && items.Count > 0)
        {
            ItemObject item = items[0];
            
            Vector3 currentPosition = transform.position;
            Vector3 forward = transform.forward;

            Vector3 newPosition = currentPosition + forward;
            newPosition += new Vector3(0, 1, 0);

            Quaternion currentRotation = transform.rotation;
            Quaternion newRotation = currentRotation * Quaternion.Euler(0, 0, 180);

            GameObject newItem = Instantiate(item.gameObject, newPosition, newRotation, worldItemsTransform);
      
            newItem.SetActive(true);

            items.Remove(item);
       
            Destroy(item.gameObject);   
        }
    }

}
