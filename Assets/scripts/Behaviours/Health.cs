using System;
using UnityEngine;

[RequireComponent(typeof(Respawner))]
public class Health : MonoBehaviour
{
    public int MaxHealth;
    public Respawner Respawner;

    private int CurrentHealth;

    public void AdjustHealth(int amount)
    {
        CurrentHealth = Math.Min(CurrentHealth + amount, MaxHealth);
        if (CurrentHealth <= 0)
        {
            Respawner.Kill(gameObject);
        }
    }
}
