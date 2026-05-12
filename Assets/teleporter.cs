using UnityEngine;

public class teleporter : MonoBehaviour
{
    public Transform destination;
    //public Vector3 destination;
    private void OnTriggerEnter2D(Collider2D collision)
    { //transform to zbiór x,y,z
      // collision.transform.position = destination;
        collision.transform.position = destination.position;
    }
}
