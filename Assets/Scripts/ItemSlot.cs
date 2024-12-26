using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("On Drop Item");
        if(eventData.pointerDrag != null)
        {
            GetComponent<Image>().sprite = eventData.pointerDrag.GetComponent<Image>().sprite;
        }
    }
}
