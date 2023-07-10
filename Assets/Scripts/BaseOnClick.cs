using UnityEngine;
using UnityEngine.EventSystems;

//������� ����� �������� ��� �����
[RequireComponent(typeof(CapsuleCollider2D))]
public abstract class BaseOnClick : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        Action();
    }

    protected abstract void Action();
}
