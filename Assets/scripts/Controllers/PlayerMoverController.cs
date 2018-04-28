using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMoverController : MoverController
{
    private Rigidbody2D Rigidbody2D;

    private void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public override void HandleMovement(int currentSprintSpeed, int currentSpeed)
    {
        float speed = (Input.GetButton(InputManager.Sprint) ? currentSprintSpeed : currentSpeed) * Time.deltaTime;
        float horizonal = Input.GetAxis(InputManager.Horizontal) * speed;
        float vertical = Input.GetAxis(InputManager.Vertical) * speed;
        var inputForce = new Vector2(horizonal, vertical);
        Rigidbody2D.AddForce(inputForce, ForceMode2D.Force);
    }

    // TODO Move out into the AbilityUserController (ability user should be the one aiming).
    public override void HandleRotation()
    {
        Vector3 playerPosition = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.x -= playerPosition.x;
        mousePosition.y -= playerPosition.y;

        float angle = (Mathf.Atan2(mousePosition.y, mousePosition.x) * Mathf.Rad2Deg) - 90.0f;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}
