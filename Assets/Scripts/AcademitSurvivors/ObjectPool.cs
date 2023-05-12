using System.Collections.Generic;
using UnityEngine;

namespace AcademitSurvivors
{
    public class ObjectPool : MonoBehaviour
    {
        [SerializeField] private GameObject _prefab;
        [SerializeField] private int _initialPoolSize;
     
        private List<GameObject> _pooledObjects = new List<GameObject>();

        private void Start()
        {
            for (var i = 0; i < _initialPoolSize; i++)
            {
                AddObjectToPool(CreateNewObject());
            }
        }

        private GameObject CreateNewObject()
        {
            var newGameObject = Instantiate(_prefab);
            newGameObject.SetActive(false);
            return newGameObject;
        }

        private void AddObjectToPool(GameObject newObject)
        {
            newObject.SetActive(false);
            _pooledObjects.Add(newObject);
        }

        public GameObject GetObjectFromPool()
        {
            foreach (var pooledObject in _pooledObjects)
            {
                if (!pooledObject.activeInHierarchy)
                {
                    pooledObject.SetActive(true);
                    return pooledObject;
                }
            }

            var newObject = CreateNewObject();
            AddObjectToPool(newObject);
            
            newObject.SetActive(true);
            return newObject;
        }
        
        public void ReturnObjectToPool(GameObject returnedObject)
        {
            returnedObject.SetActive(false);
        }
    }
}