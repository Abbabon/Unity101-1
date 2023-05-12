using System.Collections;
using UnityEngine;

namespace AcademitSurvivors
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private Mover _mover;
        
        private const float _raycastDistance = 0.2f;
        private const float _timeout = 5f;
        
        private float _timeoutCounter = 0f;
        
        private void OnEnable()
        {
            _timeoutCounter = 0;
            StartCoroutine(Timeout());
        }

        private IEnumerator Timeout()
        {
            while (_timeoutCounter < _timeout)
            {
                _timeoutCounter += Time.deltaTime;
                yield return null;
            }
            GameManager.Instance.BulletTimeout(gameObject);
        }

        private void Update()
        { 
            var ray = new Ray(transform.position, _mover.MovementVector);

            // Check if the ray hits any objects
            if (Physics.Raycast(ray, out var hit, _raycastDistance))
            {
                var hitGameObject = hit.transform.gameObject;
                var hitEnemy = hitGameObject.CompareTag(ProjectTags.EnemyTag);
                if (hitEnemy)
                {
                    GameManager.Instance.BulletHitEnemy(gameObject, hitGameObject);
                }       
            }
        }
    }
}