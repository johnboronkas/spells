using System;
using System.Collections;
using UnityEngine;

public class AbilityUser : MonoBehaviour
{
    public AbilityUserController AbilityUserController;

    public int MaxEnergy;
    public int CurrentEnergy;
    public int MaxRechargeRatePerSec;
    public int CurrentRechargeRatePerSec;

    private void Start()
    {
        StartCoroutine("RechargeEnergy");
    }

    private IEnumerator RechargeEnergy()
    {
        while(true)
        {
            yield return new WaitForSeconds(1.0f);
            AdjustEnergy(CurrentRechargeRatePerSec);
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
