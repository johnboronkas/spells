using UnityEngine;

public class AbilityUser : MonoBehaviour
{
    public AbilityUserController AbilityUserController;

    private void Update()
    {
        AbilityUserController.HandleRotation();
        AbilityUserController.HandleAbilities();
    }
}
