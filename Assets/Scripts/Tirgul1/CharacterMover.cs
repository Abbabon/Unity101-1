using UnityEngine;

namespace Tirgul1
{
    public class CharacterMover : MonoBehaviour
    {
        [SerializeField] private Transform _characterTransform;
        [SerializeField] private Rigidbody _characterRigidbody;
        [SerializeField] private float _movementSpeed;
        [SerializeField] private float _rotationSpeed;
        [SerializeField] private float _jumpForce;

        // Update is called once per frame
        void Update()
        {
            var horizontalInput = Input.GetAxis("Horizontal");
            var horizontalMovementDelta = horizontalInput * _movementSpeed * Time.deltaTime;
            _characterTransform.localPosition += _characterTransform.TransformDirection(Vector3.right) * horizontalMovementDelta;
            
            var verticalInput = Input.GetAxis("Vertical");
            var verticalMovementDelta = verticalInput * _movementSpeed * Time.deltaTime;
            _characterTransform.localPosition += _characterTransform.TransformDirection(Vector3.forward) * verticalMovementDelta;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                _characterRigidbody.AddForce(Vector3.up * _jumpForce);
            }
            
            var mouseX = Input.GetAxis("Mouse X") * _rotationSpeed;
            _characterTransform.Rotate(0, mouseX, 0, Space.World);
        }
    }
}
