using UnityEngine;

public class Target : MonoBehaviour
{
    [Header("Stats")]
    public float health = 50f;

    public void takeDamage (float damage)
    {
        health -= damage;
        if (health <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
