// GENERATED AUTOMATICALLY FROM 'Assets/Scrpit/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Touch"",
            ""id"": ""356cae54-a93b-4cb6-b868-87049c7c6bc6"",
            ""actions"": [
                {
                    ""name"": ""PrimaryFingerPosition"",
                    ""type"": ""Value"",
                    ""id"": ""75d326b2-6db3-4ee5-9f40-1dc35137aeb1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondaryFingerPosition"",
                    ""type"": ""Value"",
                    ""id"": ""7c74bc33-8454-4492-afe1-c3d9966071d0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondaryTouchContact"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6f070fe6-a40b-42d1-b520-df1935e1f28c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Touch0Delta"",
                    ""type"": ""Value"",
                    ""id"": ""363ec954-48c7-4a5a-bee3-2049b87cf38b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Touch0Down"",
                    ""type"": ""Button"",
                    ""id"": ""0c9e9a43-15f6-4054-9671-ae39c7cf776b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Touch0Touch"",
                    ""type"": ""Value"",
                    ""id"": ""26a7bc34-16bc-4dea-b7aa-984961379023"",
                    ""expectedControlType"": ""Touch"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TouchCount"",
                    ""type"": ""Value"",
                    ""id"": ""d5f5bcad-957d-47bd-a7c1-05612f977b0e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e91c934b-dc84-4bcb-b82d-f7123be37ec3"",
                    ""path"": ""<Touchscreen>/touch0/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryFingerPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eed1ca25-84a1-43b3-bfbc-bd92cd30c25a"",
                    ""path"": ""<Touchscreen>/touch1/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryFingerPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97081cbb-e34b-4d99-81f0-8b145476da66"",
                    ""path"": ""<Touchscreen>/touch1/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryTouchContact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""418d3eb8-278a-4eb3-bbe9-ef1a726756d1"",
                    ""path"": ""<Touchscreen>/primaryTouch/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.05,y=0.05),StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""Touch0Delta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0739a55a-1bc0-4140-af59-904ffa4b1835"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Touch0Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2c8091a7-7fbd-4ed2-b244-04906c714660"",
                    ""path"": ""<Touchscreen>/primaryTouch/tapCount"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchCount"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""19528b69-4e88-4db9-a09f-49dca3074786"",
                    ""path"": ""<Touchscreen>/primaryTouch"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Touch0Touch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Mouse"",
            ""id"": ""a4c30f31-ea0f-4088-b370-38ea61031a80"",
            ""actions"": [
                {
                    ""name"": ""Whell"",
                    ""type"": ""PassThrough"",
                    ""id"": ""18b4c3f0-5d20-4aa0-8c91-2c5c7d202997"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mouse0Delta"",
                    ""type"": ""Value"",
                    ""id"": ""0482705a-01ec-48fa-89e8-676c685825e1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mouse0Down"",
                    ""type"": ""Button"",
                    ""id"": ""020c1372-2274-4145-aa02-870251f31f62"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mouse0DownPos"",
                    ""type"": ""Value"",
                    ""id"": ""0062d472-a7b3-488a-9776-1260c4a98c2a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""WheelDown"",
                    ""type"": ""Button"",
                    ""id"": ""c7fc7c21-34aa-44d5-96e6-1186c22dd97c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5812028c-8a4a-475c-9eac-3ecf64dd01e4"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": ""Clamp(min=-1,max=1)"",
                    ""groups"": """",
                    ""action"": ""Whell"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""621bd338-7c75-47ad-8d8a-7c2aed015e35"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.05,y=0.05),StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""Mouse0Delta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f159f470-ebc4-4a11-a4db-565b4a294a7a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse0Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b0db2ba-bb3d-4c84-8dac-d9afc48caf54"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WheelDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00fb5a26-3240-42a5-812b-5c5bf51251cb"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse0DownPos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Touch
        m_Touch = asset.FindActionMap("Touch", throwIfNotFound: true);
        m_Touch_PrimaryFingerPosition = m_Touch.FindAction("PrimaryFingerPosition", throwIfNotFound: true);
        m_Touch_SecondaryFingerPosition = m_Touch.FindAction("SecondaryFingerPosition", throwIfNotFound: true);
        m_Touch_SecondaryTouchContact = m_Touch.FindAction("SecondaryTouchContact", throwIfNotFound: true);
        m_Touch_Touch0Delta = m_Touch.FindAction("Touch0Delta", throwIfNotFound: true);
        m_Touch_Touch0Down = m_Touch.FindAction("Touch0Down", throwIfNotFound: true);
        m_Touch_Touch0Touch = m_Touch.FindAction("Touch0Touch", throwIfNotFound: true);
        m_Touch_TouchCount = m_Touch.FindAction("TouchCount", throwIfNotFound: true);
        // Mouse
        m_Mouse = asset.FindActionMap("Mouse", throwIfNotFound: true);
        m_Mouse_Whell = m_Mouse.FindAction("Whell", throwIfNotFound: true);
        m_Mouse_Mouse0Delta = m_Mouse.FindAction("Mouse0Delta", throwIfNotFound: true);
        m_Mouse_Mouse0Down = m_Mouse.FindAction("Mouse0Down", throwIfNotFound: true);
        m_Mouse_Mouse0DownPos = m_Mouse.FindAction("Mouse0DownPos", throwIfNotFound: true);
        m_Mouse_WheelDown = m_Mouse.FindAction("WheelDown", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Touch
    private readonly InputActionMap m_Touch;
    private ITouchActions m_TouchActionsCallbackInterface;
    private readonly InputAction m_Touch_PrimaryFingerPosition;
    private readonly InputAction m_Touch_SecondaryFingerPosition;
    private readonly InputAction m_Touch_SecondaryTouchContact;
    private readonly InputAction m_Touch_Touch0Delta;
    private readonly InputAction m_Touch_Touch0Down;
    private readonly InputAction m_Touch_Touch0Touch;
    private readonly InputAction m_Touch_TouchCount;
    public struct TouchActions
    {
        private @Controls m_Wrapper;
        public TouchActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @PrimaryFingerPosition => m_Wrapper.m_Touch_PrimaryFingerPosition;
        public InputAction @SecondaryFingerPosition => m_Wrapper.m_Touch_SecondaryFingerPosition;
        public InputAction @SecondaryTouchContact => m_Wrapper.m_Touch_SecondaryTouchContact;
        public InputAction @Touch0Delta => m_Wrapper.m_Touch_Touch0Delta;
        public InputAction @Touch0Down => m_Wrapper.m_Touch_Touch0Down;
        public InputAction @Touch0Touch => m_Wrapper.m_Touch_Touch0Touch;
        public InputAction @TouchCount => m_Wrapper.m_Touch_TouchCount;
        public InputActionMap Get() { return m_Wrapper.m_Touch; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TouchActions set) { return set.Get(); }
        public void SetCallbacks(ITouchActions instance)
        {
            if (m_Wrapper.m_TouchActionsCallbackInterface != null)
            {
                @PrimaryFingerPosition.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryFingerPosition;
                @SecondaryFingerPosition.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryFingerPosition;
                @SecondaryFingerPosition.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryFingerPosition;
                @SecondaryFingerPosition.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryFingerPosition;
                @SecondaryTouchContact.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryTouchContact;
                @SecondaryTouchContact.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryTouchContact;
                @SecondaryTouchContact.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnSecondaryTouchContact;
                @Touch0Delta.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouch0Delta;
                @Touch0Delta.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouch0Delta;
                @Touch0Delta.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouch0Delta;
                @Touch0Down.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouch0Down;
                @Touch0Down.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouch0Down;
                @Touch0Down.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouch0Down;
                @Touch0Touch.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouch0Touch;
                @Touch0Touch.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouch0Touch;
                @Touch0Touch.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouch0Touch;
                @TouchCount.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouchCount;
                @TouchCount.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouchCount;
                @TouchCount.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouchCount;
            }
            m_Wrapper.m_TouchActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PrimaryFingerPosition.started += instance.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.performed += instance.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.canceled += instance.OnPrimaryFingerPosition;
                @SecondaryFingerPosition.started += instance.OnSecondaryFingerPosition;
                @SecondaryFingerPosition.performed += instance.OnSecondaryFingerPosition;
                @SecondaryFingerPosition.canceled += instance.OnSecondaryFingerPosition;
                @SecondaryTouchContact.started += instance.OnSecondaryTouchContact;
                @SecondaryTouchContact.performed += instance.OnSecondaryTouchContact;
                @SecondaryTouchContact.canceled += instance.OnSecondaryTouchContact;
                @Touch0Delta.started += instance.OnTouch0Delta;
                @Touch0Delta.performed += instance.OnTouch0Delta;
                @Touch0Delta.canceled += instance.OnTouch0Delta;
                @Touch0Down.started += instance.OnTouch0Down;
                @Touch0Down.performed += instance.OnTouch0Down;
                @Touch0Down.canceled += instance.OnTouch0Down;
                @Touch0Touch.started += instance.OnTouch0Touch;
                @Touch0Touch.performed += instance.OnTouch0Touch;
                @Touch0Touch.canceled += instance.OnTouch0Touch;
                @TouchCount.started += instance.OnTouchCount;
                @TouchCount.performed += instance.OnTouchCount;
                @TouchCount.canceled += instance.OnTouchCount;
            }
        }
    }
    public TouchActions @Touch => new TouchActions(this);

    // Mouse
    private readonly InputActionMap m_Mouse;
    private IMouseActions m_MouseActionsCallbackInterface;
    private readonly InputAction m_Mouse_Whell;
    private readonly InputAction m_Mouse_Mouse0Delta;
    private readonly InputAction m_Mouse_Mouse0Down;
    private readonly InputAction m_Mouse_Mouse0DownPos;
    private readonly InputAction m_Mouse_WheelDown;
    public struct MouseActions
    {
        private @Controls m_Wrapper;
        public MouseActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Whell => m_Wrapper.m_Mouse_Whell;
        public InputAction @Mouse0Delta => m_Wrapper.m_Mouse_Mouse0Delta;
        public InputAction @Mouse0Down => m_Wrapper.m_Mouse_Mouse0Down;
        public InputAction @Mouse0DownPos => m_Wrapper.m_Mouse_Mouse0DownPos;
        public InputAction @WheelDown => m_Wrapper.m_Mouse_WheelDown;
        public InputActionMap Get() { return m_Wrapper.m_Mouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseActions set) { return set.Get(); }
        public void SetCallbacks(IMouseActions instance)
        {
            if (m_Wrapper.m_MouseActionsCallbackInterface != null)
            {
                @Whell.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnWhell;
                @Whell.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnWhell;
                @Whell.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnWhell;
                @Mouse0Delta.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouse0Delta;
                @Mouse0Delta.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouse0Delta;
                @Mouse0Delta.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouse0Delta;
                @Mouse0Down.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouse0Down;
                @Mouse0Down.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouse0Down;
                @Mouse0Down.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouse0Down;
                @Mouse0DownPos.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouse0DownPos;
                @Mouse0DownPos.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouse0DownPos;
                @Mouse0DownPos.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouse0DownPos;
                @WheelDown.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnWheelDown;
                @WheelDown.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnWheelDown;
                @WheelDown.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnWheelDown;
            }
            m_Wrapper.m_MouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Whell.started += instance.OnWhell;
                @Whell.performed += instance.OnWhell;
                @Whell.canceled += instance.OnWhell;
                @Mouse0Delta.started += instance.OnMouse0Delta;
                @Mouse0Delta.performed += instance.OnMouse0Delta;
                @Mouse0Delta.canceled += instance.OnMouse0Delta;
                @Mouse0Down.started += instance.OnMouse0Down;
                @Mouse0Down.performed += instance.OnMouse0Down;
                @Mouse0Down.canceled += instance.OnMouse0Down;
                @Mouse0DownPos.started += instance.OnMouse0DownPos;
                @Mouse0DownPos.performed += instance.OnMouse0DownPos;
                @Mouse0DownPos.canceled += instance.OnMouse0DownPos;
                @WheelDown.started += instance.OnWheelDown;
                @WheelDown.performed += instance.OnWheelDown;
                @WheelDown.canceled += instance.OnWheelDown;
            }
        }
    }
    public MouseActions @Mouse => new MouseActions(this);
    public interface ITouchActions
    {
        void OnPrimaryFingerPosition(InputAction.CallbackContext context);
        void OnSecondaryFingerPosition(InputAction.CallbackContext context);
        void OnSecondaryTouchContact(InputAction.CallbackContext context);
        void OnTouch0Delta(InputAction.CallbackContext context);
        void OnTouch0Down(InputAction.CallbackContext context);
        void OnTouch0Touch(InputAction.CallbackContext context);
        void OnTouchCount(InputAction.CallbackContext context);
    }
    public interface IMouseActions
    {
        void OnWhell(InputAction.CallbackContext context);
        void OnMouse0Delta(InputAction.CallbackContext context);
        void OnMouse0Down(InputAction.CallbackContext context);
        void OnMouse0DownPos(InputAction.CallbackContext context);
        void OnWheelDown(InputAction.CallbackContext context);
    }
}
