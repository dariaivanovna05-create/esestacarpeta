using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotInventario : MonoBehaviour, IDropHandler
{
    public Image image;
    public Color selected, notselected;

    private void wake()
    {
        Deselect();
    }

    public void Select()
    {
        image.color = selected;
    }
    public void Deselect()
    {
        image.color = notselected;
    }
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        ItemInventario itemInventario = dropped.GetComponent<ItemInventario>();
        itemInventario.parentAfterDrag = transform;
    }

}
