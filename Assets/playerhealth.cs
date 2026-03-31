using System;
using System.Collections;
using UnityEngine;

public class playerhealth : MonoBehaviour
{
  public float maxHealth =10;
  private float health;
  private bool canReciveDamage;
         //  private bool canReciveHeal;
  public float invincibilityTimer = 2;

    public delegate void HealthChangedHandler(float newhealth,float amountChanged);
    public event HealthChangedHandler OnHealthChanged;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddDamage(float damage)
    {
        if (canReciveDamage)
        {
            health -= damage;
            OnHealthChanged?.Invoke(health, -damage);
            canReciveDamage = false;
            StartCoroutine(InvincibilityTimer(invincibilityTimer, ResetInvincibility));
        }
            Debug.Log(health);
        }

    IEnumerator InvincibilityTimer(float time, Action callback)
    {
        yield return new WaitForSeconds(time);
        callback.Invoke();
    }

    private void ResetInvincibility()
    {
        canReciveDamage = true;
        Debug.Log("reset");
    }
    public void AddHealth(float healthToAdd)
    {
        health += healthToAdd;
        OnHealthChanged?.Invoke(health, healthToAdd);
        Debug.Log(health);
    }
}
