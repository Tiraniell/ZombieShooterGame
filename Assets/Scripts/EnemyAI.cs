
using UnityEngine;

namespace LernProject
{

    public class EnemyAI : MonoBehaviour
    {
        [SerializeField] float seeDistance = 5f;
        [SerializeField] float attackDistance = 1f;
        [SerializeField] float enemySpeed;
        [SerializeField] private PlayerController target;
        

        void Start()
        {
            target = FindObjectOfType<PlayerController>();
        }

        void Update()
        {
            if (Vector3.Distance(transform.position, target.transform.position) < attackDistance)
            {
                if (Vector3.Distance(transform.position, target.transform.position) < seeDistance)
                {
                    transform.LookAt(target.transform);
                    transform.Translate(new Vector3(0, 0, enemySpeed * Time.deltaTime));
                }

            }
            else
            {
            }
        }
        #region CanSeePlayer
        //bool CanSeePlayer()    // ѕроверка угла зрени€       
        //{

        //    RaycastHit hit;
        //    var direction = target.transform.position - transform.position;//рассчет рассто€ни€

        //    if ((Vector3.Angle(direction, transform.forward)) <= 90f * 0.5f) //проверка на вхождение в зону видимости
        //    {

        //        if (Physics.Raycast(transform.position, direction, out hit, _lookRotate))//проверка на вхождение игрока в зону
        //        {
        //            return (hit.transform.CompareTag("Player"));
        //        }
        //    }

        //    return false;
        //}
        #endregion

    }
}
