using UnityEngine;

public class healthpack1 : MonoBehaviour
{
    public float health = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.GetComponent<PlayerHealth>().AddHealth(health);
        Destroy(gameObject);
    }
}
