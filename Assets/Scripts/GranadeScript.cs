using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GranadeScript : MonoBehaviour
{
    public GameObject explotionEffect;
    public float delay = 3f;

    public float explotionForce = 10f;
    public float radius = 20f;    

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Explode", delay);
    }

    private void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach(Collider near in colliders)
        {
            Rigidbody rig = near.GetComponent<Rigidbody>();
            if (rig != null)
                rig.AddExplosionForce(explotionForce, transform.position, radius, 1f, ForceMode.Impulse);
        }
        Instantiate(explotionEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
