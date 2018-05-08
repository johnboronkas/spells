using System;
using System.Collections;
using UnityEngine;

public class AbilityUser : MonoBehaviour
{
    public AbilityUserController AbilityUserController;

    public int MaxEnergy = 50;
    public int CurrentEnergy = 25;
    public int RechargeRatePerTick = 1;
    public float TickLengthSeconds = 0.25f;

    private void Start()
    {
        StartCoroutine("RechargeEnergy");
    }

    private IEnumerator RechargeEnergy()
    {
        while (true)
        {
            yield return new WaitForSeconds(TickLengthSeconds);
            AdjustEnergy(RechargeRatePerTick);
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
