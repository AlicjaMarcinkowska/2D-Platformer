using UnityEngine;

public class healthpack : MonoBehaviour
{
    public float health = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.GetComponent<PlayerHealth>().AddHealth(health);
        Destroy(gameObject);
    }
}
