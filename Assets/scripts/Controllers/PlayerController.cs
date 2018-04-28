using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO REMOVE -- NO LONGER BEING USED, JUST HERE FOR REF
// TODO Move into AbilityUserController (most of this will probably go there)
// TODO Don't forget array for list of abilities.
public class PlayerController : MonoBehaviour
{
    public BounceBolt BounceBolt;
    public Texture2D CursorTexture;

    private float ProjectileSpawnDistance;

    private void Start()
    {
        ProjectileSpawnDistance = 0.2f;        
        SetCursor(CursorTexture);
    }

    private void SetCursor(Texture2D cursorTexture)
    {
        var cursorHotSpot = new Vector2(cursorTexture.width / 2, cursorTexture.height / 2);
        Cursor.SetCursor(cursorTexture, cursorHotSpot, CursorMode.Auto);
    }

    private void Update()
    {
        HandleAbilities();
    }
    
    private void HandleAbilities()
    {
        if (Input.GetButtonDown(InputManager.Ability1))
        {
            UseBounceBolt();
        }
    }

    private void UseBounceBolt()
    {
        var position = transform.position + (ProjectileSpawnDistance * transform.up);
        var rotation = transform.rotation;
        Instantiate(BounceBolt, position, rotation);
    }
}
