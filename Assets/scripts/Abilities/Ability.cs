using UnityEngine;

public abstract class Ability : MonoBehaviour
{
    public abstract void Activate(Transform transform, AbilityUser abilityUser);
}
