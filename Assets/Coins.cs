using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Coins : MonoBehaviour

{
    public int point = 1;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<PlayerCoins>().AddPoints(point);
        Destroy(gameObject);
    }
}