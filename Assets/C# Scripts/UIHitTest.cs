using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;


public static class UIHitTest
{
    public static bool ClickUIFromWorld(Camera cam, Vector3 worldPos)
    {
        Vector3 screenPos = cam.WorldToScreenPoint(worldPos);

        PointerEventData eventData = new PointerEventData(EventSystem.current);
        eventData.position = screenPos;

        List<RaycastResult> hits = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, hits);

        if (hits.Count == 0)
        {
            return false; // nothing under that point
        }

        GameObject target = hits[0].gameObject;

        ExecuteEvents.Execute(
            target,
            eventData,
            ExecuteEvents.pointerClickHandler
        );
        return true;
    }
}
