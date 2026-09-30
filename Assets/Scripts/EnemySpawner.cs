using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyGameObject;
    public Transform spawnTransform;
    public float spawnInterval = 2f;
    private void Start()
    {
        StartCoroutine(SpawnObjects());
    }
    public IEnumerator SpawnObjects()
    {
       
        while(true)
        {
            Vector3 pos = spawnTransform.position;
            pos.y = Random.Range(-3f, 3f);
            Instantiate(enemyGameObject, pos,spawnTransform.rotation);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
