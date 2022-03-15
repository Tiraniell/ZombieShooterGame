
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] float seeDistance = 5f;
    [SerializeField] float attackDistance = 1f;
    [SerializeField] float enemySpeed;
    private Transform targert;
    void Start()
    {
        targert = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, targert.transform.position) < attackDistance)
        {
            if (Vector3.Distance(transform.position, targert.transform.position) < seeDistance)
            {
                transform.LookAt(targert.transform);
                transform.Translate(new Vector3 (0, 0, enemySpeed * Time.deltaTime));
            }

        }else 
        { 
        }

        
    }
}
