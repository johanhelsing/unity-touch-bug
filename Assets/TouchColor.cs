using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchColor : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private MeshRenderer renderer;

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        renderer.material.color = Color.red;
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        renderer.material.color = Color.blue;
    }
}
