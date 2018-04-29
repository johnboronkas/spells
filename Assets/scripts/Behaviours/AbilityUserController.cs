using UnityEngine;

public abstract class AbilityUserController : MonoBehaviour
{
    public abstract void HandleRotation();
    public abstract void HandleAbilities(AbilityUser abilityUser);
}
