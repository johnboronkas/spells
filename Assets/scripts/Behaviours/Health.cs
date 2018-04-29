using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int MaxHealth;
    public int CurrentHealth;
    public Respawner Respawner;

    public void AdjustHealth(int amount)
    {
        CurrentHealth = Math.Min(CurrentHealth + amount, MaxHealth);
        if (CurrentHealth <= 0)
        {
            Respawner.Kill(gameObject);
        }
    }
}
