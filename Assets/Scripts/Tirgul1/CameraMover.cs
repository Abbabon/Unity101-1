using UnityEngine;

namespace Tirgul1
{
    public class CameraMover : MonoBehaviour
    {
        [SerializeField] private Transform _camera;
        [SerializeField] private float _scrollSpeed;
        
        
        // Update is called once per frame
        void Update()
        {
            var scrollFactor = Input.GetAxis("Mouse ScrollWheel");
            _camera.localPosition += Vector3.up * (scrollFactor * -1 * _scrollSpeed * Time.deltaTime);
        }
    }
}
