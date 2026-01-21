using UnityEngine;

public class DemoScript : MonoBehaviour
{
    public InventoryManager inventoryManager;
    public Item[] itemsTP;  
    
    public void PickUpItem(int id)
    {
        bool result = inventoryManager.AddItem(itemsTP[id]);

        if (result == true)
        {
            Debug.Log("itemadded");
        }

        else
        {
            Debug.Log("NOOOOOOOOOO");
        }
    }
}
