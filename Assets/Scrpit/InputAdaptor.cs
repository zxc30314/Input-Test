using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Linq;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

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
            var pos0 = _controls.Touch.PrimaryFingerPosition.ReadValue<Vector2>();
            var pos1 = _controls.Touch.SecondaryFingerPosition.ReadValue<Vector2>();

            if (!IsPointerOverUIObject(pos0) && !IsPointerOverUIObject(pos1))
            {
                ZoomStart();
            }
        };
        _controls.Touch.SecondaryTouchContact.canceled += _ =>
        {
            ZoomEnd();
        };
        _controls.Mouse.Whell.performed += _ => _inputData.Scroll = _.ReadValue<float>();

        _controls.Mouse.Mouse0Down.started += _ =>
        {
            _inputData.GetFristButton = !IsPointerOverUIObject(_controls.Mouse.Mouse0DownPos.ReadValue<Vector2>());
        };
        _controls.Mouse.Mouse0Down.canceled += _ => _inputData.GetFristButton = false;
        _controls.Mouse.Mouse0Delta.performed += _ => _inputData.Delta = _.ReadValue<Vector2>();

        _controls.Touch.Touch0Down.started += _ =>
        {
            _inputData.GetFristButton =
                !IsPointerOverUIObject(_controls.Touch.Touch0Touch.ReadValue<UnityEngine.InputSystem.LowLevel.TouchState>().position);
        };
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

    private bool IsPointerOverUIObject(Vector2 pos)
    {
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = pos;
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
        return results.Count(x => x.gameObject.layer == LayerMask.NameToLayer("UI")) > 0;
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
        if (zoomCoroutine != null)
        {
            StopCoroutine(zoomCoroutine);
            zoomCoroutine = null;
        }

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