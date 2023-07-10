using UnityEngine;

/// <summary>
/// Отрытие кнопки при нажатии
/// </summary>
public class OnClickOpenButton : BaseOnClick
{
    [SerializeField]
    private GameObject _button;

    protected override void Action()
    {
        _button.SetActive(true);
    }
}
