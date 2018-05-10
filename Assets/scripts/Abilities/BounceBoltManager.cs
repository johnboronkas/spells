using System.Collections;
using UnityEngine;

public class BounceBoltManager : AbilityManager
{
    public BounceBolt BounceBolt;

    private Transform Transform;
    private AbilityUser AbilityUser;
    private float NextShotTime;
    private bool IsShooting;

    public override void Activate(Transform transform, AbilityUser abilityUser)
    {
        Transform = transform;
        AbilityUser = abilityUser;

        IsShooting = true;
    }

    private void Update()
    {
        if (IsShooting && NextShotTime <= Time.time && AbilityUser.CanAffordAbility(BounceBolt.EnergyCost))
        {
            AbilityUser.AdjustEnergy(-BounceBolt.EnergyCost);

            Vector3 position = Transform.position + (BounceBolt.ProjectileSpawnDistance * Transform.up);
            Instantiate(BounceBolt, position, Transform.rotation);

            NextShotTime = Time.time + BounceBolt.ShotCooldownSec;
        }
    }

    public override void Deactivate(Transform transform, AbilityUser abilityUser)
    {
        IsShooting = false;
    }
}
