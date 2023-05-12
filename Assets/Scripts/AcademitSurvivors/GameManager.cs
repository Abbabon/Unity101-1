using System.Runtime.CompilerServices;
using UnityEngine;

namespace AcademitSurvivors
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private ObjectPool _enemyObjectPool;
        [SerializeField] private ObjectPool _bulletObjectPool;
        
        public static GameManager Instance { get; private set; }

        private void Awake()
        {
            if (Instance != null && Instance != this) 
            { 
                Destroy(this);
            } 
            else 
            { 
                Instance = this; 
            }
            
            DontDestroyOnLoad(this);
        }

        public void EnemyReachedGate(GameObject enemyGameObject)
        {
            _enemyObjectPool.ReturnObjectToPool(enemyGameObject);
        }

        public void BulletHitEnemy(GameObject bulletGameObject, GameObject enemyGameObject)
        {
            _bulletObjectPool.ReturnObjectToPool(bulletGameObject);
            enemyGameObject.GetComponent<Enemy>()?.Die();
        }

        public void BulletTimeout(GameObject bulletGameObject)
        {
            _bulletObjectPool.ReturnObjectToPool(bulletGameObject);
        }
        
        public void CorpseTimeout(GameObject corpseGameObject)
        {
            _enemyObjectPool.ReturnObjectToPool(corpseGameObject);
        }
    }
}