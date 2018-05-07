using UnityEngine;

public class PlayerAbilityUserController : AbilityUserController
{
    public Ability[] Abilities;
    public Texture2D CursorTexture;

    private float[] LastAbilityActivationTimes;

    private void Start()
    {
        LastAbilityActivationTimes = new float[Abilities.Length];
        SetCursor(CursorTexture);
    }

    private void SetCursor(Texture2D cursorTexture)
    {
        var cursorHotSpot = new Vector2(cursorTexture.width / 2, cursorTexture.height / 2);
        Cursor.SetCursor(cursorTexture, cursorHotSpot, CursorMode.Auto);
    }

    public override void HandleRotation()
    {
        Vector3 playerPosition = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.x -= playerPosition.x;
        mousePosition.y -= playerPosition.y;

        float angle = (Mathf.Atan2(mousePosition.y, mousePosition.x) * Mathf.Rad2Deg) - 90.0f;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }

    public override void HandleAbilities(AbilityUser abilityUser)
    {
        if (Input.GetButton(InputManager.Ability1))
        {
            LastAbilityActivationTimes[0] = Abilities[0].Activate(gameObject.transform, abilityUser, LastAbilityActivationTimes[0]);
        }
    }
}
