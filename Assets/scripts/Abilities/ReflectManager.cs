using UnityEngine;

public class ReflectManager : AbilityManager
{
    public Reflect Reflect;
    private Reflect Clone;

    public override void Activate(Transform transform, AbilityUser abilityUser)
    {
        // TODO Continuous energy drain
        if (abilityUser.CanAffordAbility(Reflect.EnergyCostPerTick))
        {
            abilityUser.AdjustEnergy(-Reflect.EnergyCostPerTick);

            Clone = Instantiate(Reflect, transform.position, transform.rotation);
            Clone.CasterTransform = transform;
            Clone.AbilityUser = abilityUser;
        }
    }

    public override void Deactivate(Transform transform, AbilityUser abilityUser)
    {
        if (Clone != null)
        {
            Destroy(Clone.gameObject);
        }
    }
}
