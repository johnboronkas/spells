using UnityEngine;

public class PlayerAbilityUserController : AbilityUserController
{
    public AbilityManager[] AbilityManagers;
    public Texture2D CursorTexture;

    private void Start()
    {
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
        if (Input.GetButtonDown(InputManager.Ability0))
        {
            AbilityManagers[0].Activate(gameObject.transform, abilityUser);
        }
        else if (Input.GetButtonUp(InputManager.Ability0))
        {
            AbilityManagers[0].Deactivate(gameObject.transform, abilityUser);
        }

        if (Input.GetButtonDown(InputManager.Ability1))
        {
            AbilityManagers[1].Activate(gameObject.transform, abilityUser);
        }
        else if (Input.GetButtonUp(InputManager.Ability1))
        {
            AbilityManagers[1].Deactivate(gameObject.transform, abilityUser);
        }
    }
}
