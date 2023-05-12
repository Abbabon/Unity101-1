using UnityEngine;

namespace AcademitSurvivors.Gizmos
{
    public class EnemyGateGizmo : MonoBehaviour
    {
        [SerializeField] private BoxCollider _boxCollider;
        
        private void OnDrawGizmos()
        {
            UnityEngine.Gizmos.color = Color.blue;
            UnityEngine.Gizmos.DrawCube(transform.position, transform.localScale);
        }
    }
}