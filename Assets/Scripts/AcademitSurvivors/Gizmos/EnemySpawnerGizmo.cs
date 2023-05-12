using UnityEngine;

namespace AcademitSurvivors.Gizmos
{
    public class EnemySpawnerGizmo : MonoBehaviour
    {
        private void OnDrawGizmos()
        {
            UnityEngine.Gizmos.color = Color.red;
            UnityEngine.Gizmos.DrawSphere(transform.position, 1.0f);
        }
    }
}