using UnityEngine;

/// <summary>
/// Срабатывание анимации при клике
/// </summary>
[RequireComponent(typeof(CapsuleCollider2D), typeof(Animation))]
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
