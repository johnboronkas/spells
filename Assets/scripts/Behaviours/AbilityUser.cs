using System;
using System.Collections;
using UnityEngine;

public class AbilityUser : MonoBehaviour
{
    public AbilityUserController AbilityUserController;

    public int MaxEnergy = 50;
    public int CurrentEnergy = 25;
    public int RechargeRatePerSec = 4;

    private void Start()
    {
        StartCoroutine("RechargeEnergy");
    }

    private IEnumerator RechargeEnergy()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            AdjustEnergy(RechargeRatePerSec);
        }
    }

    private void Update()
    {
        AbilityUserController.HandleRotation();
        AbilityUserController.HandleAbilities(this);
    }

    public bool CanAffordAbility(int energyCost)
    {
        return (CurrentEnergy - energyCost) >= 0;
    }

    public void AdjustEnergy(int amount)
    {
        CurrentEnergy = Math.Min(CurrentEnergy + amount, MaxEnergy);
    }
}
