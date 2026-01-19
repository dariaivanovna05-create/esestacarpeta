using UnityEngine;
using UnityEngine.EventSystems;

public class SlotInventario : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        ItemInventario itemInventario = dropped.GetComponent<ItemInventario>();
        itemInventario.parentAfterDrag = transform;
    }

}
