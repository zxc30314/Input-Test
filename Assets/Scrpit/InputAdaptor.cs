using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.Controls;

class InputAdaptor : MonoBehaviour
{
    private Controls _controls;
    private InputData _inputData;
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
        _controls.Touch.SecondaryTouchContact.started += _ =>
        {
            if (_inputData.GetFristButton)
            {
                ZoomStart();
            }
        };
        _controls.Touch.SecondaryTouchContact.canceled += _ =>
        {
            if (_inputData.GetFristButton)
            {
                ZoomEnd();
            }
        };
        _controls.Mouse.Whell.performed += _ => _inputData.Scroll = _.ReadValue<float>();

        _controls.Mouse.Mouse0Down.started += _ => _inputData.GetFristButton = !EventSystem.current.IsPointerOverGameObject();
        _controls.Mouse.Mouse0Down.canceled += _ => _inputData.GetFristButton = false;
        _controls.Mouse.Mouse0Delta.performed += _ => _inputData.Delta = _.ReadValue<Vector2>();

        _controls.Touch.Touch0Down.started += _ => Invoke(nameof(SetGetFirstButtonForOnUI),0.0001f);
        _controls.Touch.Touch0Down.canceled += _ => _inputData.GetFristButton = false;
        _controls.Touch.Touch0Delta.performed += _ =>
        {
            _inputData.Delta = _.ReadValue<Vector2>();
            if (Input.touchCount != 1)
            {
                _inputData.GetFristButton = false;
            }
        };

        _controls.Mouse.WheelDown.started += _ => _inputData.GetScrollButton = true;
        _controls.Mouse.WheelDown.canceled += _ => _inputData.GetScrollButton = false;
    }

    void SetGetFirstButtonForOnUI()
    {
        _inputData.GetFristButton = !EventSystem.current.IsPointerOverGameObject();
    }

    public InputData GetData()
    {
        return _inputData;
    }

    private void ZoomStart()
    {
        zoomCoroutine = StartCoroutine(ZoomDetection());
    }

    private void ZoomEnd()
    {
        StopCoroutine(zoomCoroutine);
        _inputData.Scroll = 0;
    }

    IEnumerator ZoomDetection()
    {
        float distance = 0;
        float previousDistance = Vector2.Distance(_controls.Touch.PrimaryFingerPosition.ReadValue<Vector2>(),
            _controls.Touch.SecondaryFingerPosition.ReadValue<Vector2>());
        while (true)
        {
            distance = Vector2.Distance(_controls.Touch.PrimaryFingerPosition.ReadValue<Vector2>(),
                _controls.Touch.SecondaryFingerPosition.ReadValue<Vector2>());

            _inputData.Scroll = (distance - previousDistance) * 0.001f;

            previousDistance = distance;
            yield return null;
        }
    }
}