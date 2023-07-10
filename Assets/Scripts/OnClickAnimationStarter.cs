using UnityEngine;

/// <summary>
/// ������������ �������� ��� �����
/// </summary>
[RequireComponent(typeof(Animation))]
public class OnClickAnimationStarter : BaseOnClick
{
    private Animation _animation;

    private void Start()
    {
        _animation = GetComponent<Animation>();
    }

    protected override void Action()
    {
        _animation.Play();
    }

}
