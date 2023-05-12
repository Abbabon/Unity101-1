using UnityEngine;

namespace AcademitSurvivors
{
    public class EnemyGate : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            var hitEnemy = other.gameObject.CompareTag(ProjectTags.EnemyTag);
            if (hitEnemy)
            {
                GameManager.Instance.EnemyReachedGate(other.gameObject);
            }
        }
    }
}