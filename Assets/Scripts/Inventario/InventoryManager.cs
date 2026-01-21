using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public SlotInventario[] slotInventarios;
    public GameObject ItemInventarioPrefab;

    int selectedSlot = -1;

    private void Start()
    {
        ChangeSlot(0);
    }

    private void Update()
    {
        if (Input.inputString != null)
        {
            bool isNumber = int.TryParse(Input.inputString, out int number);
            if (isNumber && number > 0 && number < 8)
            {
                ChangeSlot(number - 1);
            }
        }
    }

    public Item GetSelectedItem()
    {
        SlotInventario slot = slotInventarios[selectedSlot];
        ItemInventario itemInSlot = slot.GetComponentInChildren<ItemInventario>();
        if (itemInSlot != null)
        {
            return itemInSlot.item;
        }

        return null;
    }

    void ChangeSlot(int newValue)
    {
        if(selectedSlot >= 0)
        {
            slotInventarios[selectedSlot].Deselect();
        }
        
        slotInventarios[newValue].Select();
        selectedSlot = newValue;
    }
    public bool AddItem(Item item)
    {
        for (int i = 0; i < slotInventarios.Length; i++)
        {
            SlotInventario slot = slotInventarios[i];
            ItemInventario itemInSlot = slot.GetComponentInChildren<ItemInventario>();

            if (itemInSlot == null)
            {
                SpawnNewItem(item, slot);
                return true;
            }

        }

        return false;
    }

    void SpawnNewItem(Item item, SlotInventario slot)
    {
        GameObject newItemGo = Instantiate(ItemInventarioPrefab, slot.transform);
        ItemInventario itemInventario = newItemGo.GetComponent<ItemInventario>();
        itemInventario.InitialiseItem(item);
    }

}
