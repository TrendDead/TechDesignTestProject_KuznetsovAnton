using UnityEngine;
using UnityEngine.EventSystems;

//Базовый класс действия при клике
[RequireComponent(typeof(CapsuleCollider2D))]
public abstract class BaseOnClick : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        Action();
    }

    protected abstract void Action();
}
