using UnityEngine;

public abstract class Ability : MonoBehaviour
{
    /**
     * Returns the last time the ability was successfully activated. Must be resent back on every call to activate.
     */ 
    public abstract float Activate(Transform transform, AbilityUser abilityUser, float lastActivationTime);
}
