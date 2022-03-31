using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileAddon : MonoBehaviour
{
    public float damage;
    private Rigidbody rb;

    private bool targetHit;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (targetHit)
            return;
        else
            targetHit = true;

        if(collision.gameObject.GetComponent<Target>() != null)
        {
            Target enemy = collision.gameObject.GetComponent<Target>();
            enemy.takeDamage(damage);

            Destroy(gameObject);
        }

        rb.isKinematic = true;

        transform.SetParent(collision.transform);
    }
}
