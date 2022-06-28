using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] GameObject _prefab;
    [SerializeField] int _countGameObject;
    [SerializeField] float _delaySeconds;
    
    private const float PositionAboveSpawnY = 5;

    private void Start()
    {
        var createGameObjectJob = StartCoroutine(CreateGameObject());
    }

    private IEnumerator CreateGameObject()
    {
        var delay = new WaitForSeconds(_delaySeconds);
        
        for (int i = 0; i < _countGameObject; i++)
        {
            Instantiate(_prefab, new Vector3(transform.position.x, transform.position.y + PositionAboveSpawnY, transform.position.z), Quaternion.identity);
            yield return delay;
        }
    }
}
