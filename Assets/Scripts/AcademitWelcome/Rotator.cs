using UnityEngine;

namespace AcademitWelcome
{
    public class Rotator : MonoBehaviour
    {
        [SerializeField] private float _degreesPerSecond = 1f;
    
        void Update()
        {
            gameObject.transform.localRotation = Quaternion.Euler(gameObject.transform.localRotation.eulerAngles +
                                                                  (Vector3.up * _degreesPerSecond * Time.deltaTime));
        }
    }
}
