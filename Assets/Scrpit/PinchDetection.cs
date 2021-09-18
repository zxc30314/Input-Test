using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class PinchDetection : MonoBehaviour
{
    private Controls _controls;
    private Coroutine zoomCoroutine;

    private void Awake()
    {
        _controls = new Controls();
    }

    private void OnEnable()
    {
        _controls.Enable();
    }

    private void OnDisable()
    {
        _controls.Disable();
    }

    private void Start()
    {
        // _controls.Touch.SecondaryTouchContact.started += _ => ZoomStart();
        // _controls.Touch.SecondaryTouchContact.canceled += _ => ZoomEnd();
        // _controls.Touch.SecondaryTouchContact.started += _ => Debug.Log(_.ReadValue<Vector2>());
        // _controls.Mouse.Whell.started += _ => Debug.Log(_.ReadValue<Vector2>());
        // _controls.Mouse.Whell.performed += _ => Debug.Log(_.ReadValue<Vector2>());
    }

    private void LateUpdate()
    {
        var vector2 = _controls.Mouse.Whell.ReadValue<Vector2>();
        Debug.Log(vector2);
    }

    private void ZoomStart()
    {
        zoomCoroutine = StartCoroutine(ZoomDetection());
    }

    private void ZoomEnd()
    {
        StopCoroutine(zoomCoroutine);
    }

    IEnumerator ZoomDetection()
    {
        float previousDistance = 0;
        float distance = 0;
        while (true)
        {
            distance = Vector2.Distance(_controls.Touch.PrimaryFingerPosition.ReadValue<Vector2>(),
                _controls.Touch.SecondaryFingerPosition.ReadValue<Vector2>());
            if (distance > previousDistance)
            {
                //Zoom In
            }
            else if (distance < previousDistance)
            {
                //Zoom Out
            }

            previousDistance = distance;
            yield break;
        }
    }
}