using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int MaxHealth;
    public int CurrentHealth;
    public Respawner Respawner;
    public GameObject[] DependentGameObjects;

    public void AdjustHealth(int amount)
    {
        CurrentHealth = Math.Min(CurrentHealth + amount, MaxHealth);
        if (CurrentHealth <= 0)
        {
            DestroyAllDependents();
            Respawner.Kill(gameObject);
        }
    }

    private void DestroyAllDependents()
    {
        if (DependentGameObjects != null)
        {
            foreach (GameObject g in DependentGameObjects)
            {
                Destroy(g);
            }
        }
    }
}
