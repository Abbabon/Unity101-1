using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace AcademitSurvivors
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private float _spawnDelayMinimum = 3f;
        [SerializeField] private float _spawnDelayMaximum = 6f;

        [SerializeField] private Transform _spawnPosition;

        [SerializeField] private ObjectPool _factory;
        

        private bool _availableForSpawning = true;

        private IEnumerator WaitAndSpawn()
        {
            _availableForSpawning = false;
            var timeToDelay = Random.Range(_spawnDelayMinimum, _spawnDelayMaximum);
            yield return new WaitForSeconds(timeToDelay);

            var newGameObject = _factory.GetObjectFromPool();
            newGameObject.transform.position = _spawnPosition.position;
            
            _availableForSpawning = true;
        }

        private void Update()
        {
            if (_availableForSpawning)
            {
                StartCoroutine(WaitAndSpawn());
            }
        }
    }
}
