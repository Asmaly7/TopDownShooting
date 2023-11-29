using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.InputSystem;
using Debug = UnityEngine.Debug;

public class PlayerInputController : TopDownCharacterController
{
    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        // Debug.Log("OnMove" + value.ToString());
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldpos = _camera.ScreenToWorldPoint(newAim);
        newAim = (worldpos - (Vector2)transform.position).normalized;

        if (newAim.magnitude >= .9f)
        {
            CallLookEvent(newAim);
        }

    }

    public void OnFire(InputValue value) 
    {
        IsAttacking = value.isPressed;
    }
}
