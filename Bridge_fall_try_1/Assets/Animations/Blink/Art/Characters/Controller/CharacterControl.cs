using UnityEngine;
using DG.Tweening;

public class CharacterControl : MonoBehaviour
{
    public Animator _animator;
    public Transform _startPoint;
    public Transform _endPoint;

    private Sequence _sequence;

    private CharacterAnimationController _animationController;
    
    private void start()
    {
        _animationController = new CharacterAnimationController(_animator);
    }

    
 private void update()
    {

      //  if (Input.GetKeyDown(KeyCode.Space))
            //PlayerCharacterSequence();
    } 
    
    private void PlayerCharacterSequence()
    {
        transform.position = _startPoint.position;
        transform.rotation = _startPoint.rotation;

        _sequence?.Kill();
        
        _sequence = DOTween.Sequence()
            .AppendCallback(PlayRunningAnimation)
            .Join(transform.DOMove(_endPoint.position, 3f))
            .AppendCallback(PlayRightTurnAnimation)
            .Join(transform.DORotateQuaternion(_endPoint.rotation, 1f))
            .AppendCallback(PlayLeftTurnAnimation)
            .Join(transform.DORotateQuaternion(_endPoint.rotation, 1f));


        print("come into Character sequence");
    }

    private void PlayIdleAnimation() => _animationController.PlayAnimation(AnimationType.Idle);
    private void PlayRunningAnimation() => _animationController.PlayAnimation(AnimationType.Running);
    private void PlayRightTurnAnimation() => _animationController.PlayAnimation(AnimationType.RightTurn);
    private void PlayLeftTurnAnimation() => _animationController.PlayAnimation(AnimationType.LeftTurn);
}
