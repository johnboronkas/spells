using System.Collections;
using UnityEngine;

public class BounceBoltManager : AbilityManager
{
    public BounceBolt BounceBolt;

    private Transform Transform;
    private AbilityUser AbilityUser;

    public override void Activate(Transform transform, AbilityUser abilityUser)
    {
        Transform = transform;
        AbilityUser = abilityUser;

        StartCoroutine("RapidFire");
    }

    private IEnumerator RapidFire()
    {
        while (true)
        {
            if (AbilityUser.CanAffordAbility(BounceBolt.EnergyCost))
            {
                AbilityUser.AdjustEnergy(-BounceBolt.EnergyCost);

                Vector3 position = Transform.position + (BounceBolt.ProjectileSpawnDistance * Transform.up);
                Instantiate(BounceBolt, position, Transform.rotation);
            }

            yield return new WaitForSeconds(BounceBolt.ShotCooldownSec);
        }
    }

    public override void Deactivate(Transform transform, AbilityUser abilityUser)
    {
        StopCoroutine("RapidFire");
    }
}
