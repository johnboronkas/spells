using UnityEngine;

public class PlayerAbilityUserController : AbilityUserController
{
    public Ability[] Abilities;
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
        if (Input.GetButtonDown(InputManager.Ability1))
        {
            Abilities[0].Activate(gameObject.transform, abilityUser);
        }
    }
}
