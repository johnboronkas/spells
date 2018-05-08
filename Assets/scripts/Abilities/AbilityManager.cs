using UnityEngine;

public abstract class AbilityManager : MonoBehaviour
{
    /**
     * Returns the last time the ability was successfully activated. Must be resent back on every call to activate.
     */ 
    public abstract void Activate(Transform transform, AbilityUser abilityUser);
    public abstract void Deactivate(Transform transform, AbilityUser abilityUser);
}
