using UnityEngine;
using UnityEngine.EventSystems;

//������� ����� �������� ��� �����
public abstract class BaseOnClick : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        Action();
    }

    protected abstract void Action();
}
