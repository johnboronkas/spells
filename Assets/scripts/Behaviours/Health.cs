using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int MaxHealth = 30;
    public int CurrentHealth = 20;
    public Respawner Respawner;

    private void Start()
    {
        if (Respawner == null)
        {
            Respawner = FindObjectOfType<Respawner>();
        }
    }

    public void AdjustHealth(int amount)
    {
        CurrentHealth = Math.Min(CurrentHealth + amount, MaxHealth);
        CheckForDeath();
    }

    public void AdjustMaxHealth(int amount)
    {
        MaxHealth = MaxHealth + amount;
        CurrentHealth = Math.Min(CurrentHealth, MaxHealth);
        CheckForDeath();
    }

    private void CheckForDeath()
    {
        if (CurrentHealth <= 0)
        {
            Respawner.Kill(gameObject);
        }
    }
}
