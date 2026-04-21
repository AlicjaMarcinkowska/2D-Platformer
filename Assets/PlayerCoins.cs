using System;
using System.Collections;
using UnityEngine;

public class PlayerCoins : MonoBehaviour
{
    private int point;
    
   public delegate void OnCoinChanged
    void Start()
    {
   
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void AddPoints(int amount)
    {
        AddPoints += amount;
        OnCoinChanged?.Invoke(point);
    }
}