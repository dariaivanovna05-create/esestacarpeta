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
            Debug.Log("item añadido :D yay");
        }

        else if (result == false)
        {
            Debug.Log("NOOOOOOOOOO");
        }

        else
        {
            Debug.Log("huh...");
        }
    }

    public void GetSelectedItem() 
    { 
        Item recievedItem = inventoryManager.GetSelectedItem();
        if (recievedItem != null)
        {
            Debug.Log("No hay item!!!");
        }
    }
}
