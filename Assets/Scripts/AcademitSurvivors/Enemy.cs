using System;
using System.Collections;
using UnityEngine;

namespace AcademitSurvivors
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private Transform _characterTransform;
        [SerializeField] private float _movementSpeed;
        [SerializeField] private Animator _animator;
        [SerializeField] private Collider _collider;

        private bool _isMoving = false;
        private float _corpseTimeoutCounter = 20f;

        private const float _corpseTimeout = 20f;
        private const string _dyingAnimationTrigger = "Die";
        private static readonly int Die1 = Animator.StringToHash(_dyingAnimationTrigger);

        private void OnEnable()
        {
            _collider.enabled = true;
            _corpseTimeoutCounter = 0;
            _isMoving = true;
        }

        private void Update()
        {
            if (_isMoving)
            {
                var movementDelta = _movementSpeed * Time.deltaTime;
                _characterTransform.localPosition += Vector3.back * movementDelta;   
            }
        }

        public void Die()
        {
            _isMoving = false;
            _collider.enabled = false;
            _animator.SetTrigger(Die1);
            StartCoroutine(HideCorpseCoroutine());
        }

        private IEnumerator HideCorpseCoroutine()
        {
            while (_corpseTimeoutCounter < _corpseTimeout)
            {
                _corpseTimeoutCounter += Time.deltaTime;
                yield return null;
            }
            GameManager.Instance.CorpseTimeout(gameObject);
        }
    }
}
