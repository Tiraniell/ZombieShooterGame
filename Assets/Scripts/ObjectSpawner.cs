using System.Collections;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] public Transform _obstacle;
    [SerializeField] private float xPos;
    [SerializeField] private float zPos;
    [SerializeField] private int enemyCount;

    
   

    void Start()
    {
        StartCoroutine(EnemyDrop());

    }

    IEnumerator EnemyDrop()
    {
        while(enemyCount < 20)
        {
            xPos = Random.Range(-25, 25);
            zPos = Random.Range(-25, 25);
            Instantiate(_obstacle, new Vector3(xPos, 0, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.01f);
            enemyCount += 1;

        }
        
    }
}
