using UnityEngine;

namespace AcademitSurvivors
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] private Transform _movingTransform;
        [SerializeField] private Vector3 _movementVector;
        [SerializeField] private float _movementSpeed;
        
        public Vector3 MovementVector => _movementVector;

        private void Update()
        {
            var movementDelta = _movementSpeed * Time.deltaTime;
            _movingTransform.localPosition += _movementVector * movementDelta;
        }
    }
}