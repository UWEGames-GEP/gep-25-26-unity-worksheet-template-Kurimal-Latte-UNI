using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerCharacterController : ThirdPersonController
{
    private void OnPause(InputValue value)
    {
        if (value.isPressed) { Debug.Log("GamePause."); }
    }
    private void OnRemoveItem(InputValue value)
    {
        if (value.isPressed)
        {
            Debug.Log("Item Remove");
            GetComponent<Inventory_Script>().RemoveItemFromInventory();
        }


    }


}
