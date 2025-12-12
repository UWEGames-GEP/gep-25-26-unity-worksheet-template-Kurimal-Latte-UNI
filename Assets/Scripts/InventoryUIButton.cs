using TMPro;
using UnityEngine;

public class InventoryUIButton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public TMP_Text text;

    public void Setbutton(ItemObject item)
    {
        text.text = item.itemname;
    }



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
