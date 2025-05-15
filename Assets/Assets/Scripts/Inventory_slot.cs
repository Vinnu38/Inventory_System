using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Inventory_slot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if(transform.childCount== 0)
        {
            GameObject dropping = eventData.pointerDrag;
            DraggableItem dragging = dropping.GetComponent<DraggableItem>();
            dragging.dragging = transform;
        }
    }
}
