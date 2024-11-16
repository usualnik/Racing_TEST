using DG.Tweening;
using UnityEngine;

public class GhostFollower : MonoBehaviour
{
   private float _duration = 60f;
   public void FollowPlayer(Vector3[] wayPoints)
   {
      // Анимируем машинку по нашим вейпоинтам. ВАЖНО: _duration это не скорость, так что если хотим чтоб машинка проходила путь быстрее _duration надо УМЕНЬШАТЬ
      Tween tween = transform.DOPath(wayPoints, _duration ).SetOptions(true).SetLookAt(0.01f);
   }
}
