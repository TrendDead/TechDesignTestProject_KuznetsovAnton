using UnityEngine;
using UnityEngine.EventSystems;

//Базовый класс действия при клике
public abstract class BaseOnClick : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        Action();
    }

    protected abstract void Action();
}
