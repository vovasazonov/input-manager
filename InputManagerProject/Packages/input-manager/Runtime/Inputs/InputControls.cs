// GENERATED AUTOMATICALLY FROM 'Packages/com.kefir.input-manager/Runtime/Inputs/InputControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputControls"",
    ""maps"": [
        {
            ""name"": ""Dpad"",
            ""id"": ""b3a3ad46-32e6-47b2-855c-6ae59dd3b666"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""ae21bd54-4b79-4d17-9950-eb7d70a5c052"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""debdc53b-0ec2-4142-b1f2-f9bc75eaad66"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""e6a18fa1-0509-4a75-b064-9082bf99520e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b9343902-f1a8-4b91-b1aa-a2446e1c1ec1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fe571667-1d75-41b1-b6b8-e38309e00ada"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a4e25f93-012a-4989-a6ae-b63598b5b27f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f6895702-837a-490c-acd7-76412fee94a9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Player Controls"",
            ""id"": ""fdd2e49a-08b0-4dc6-8069-62ee1a3e8815"",
            ""actions"": [
                {
                    ""name"": ""Scale"",
                    ""type"": ""Value"",
                    ""id"": ""21d0446f-40b6-4d1b-977b-0803fa474c50"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""95763227-e373-4dbc-8ad1-1968612eeacc"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scale"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Pinch"",
                    ""id"": ""ccb0c205-544c-4a06-b93a-594b20d66024"",
                    ""path"": ""Custom"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scale"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifierTouchContact1"",
                    ""id"": ""08a9730e-f8e5-4399-ae33-88be3e9db5dd"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scale"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""modifierTouchContact2"",
                    ""id"": ""91365d18-b5f9-4fb9-a780-c153fba70e47"",
                    ""path"": ""<Touchscreen>/touch1/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scale"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positionXTouch1"",
                    ""id"": ""a2e9b356-f9fc-4392-bf0b-754eeed08517"",
                    ""path"": ""<Touchscreen>/primaryTouch/position/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scale"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positionYTouch1"",
                    ""id"": ""78341493-607d-4034-94f5-a598f7afa7c6"",
                    ""path"": ""<Touchscreen>/primaryTouch/position/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scale"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positionXTouch2"",
                    ""id"": ""8bb45dad-7499-464e-b557-53ab4c4735b3"",
                    ""path"": ""<Touchscreen>/touch1/position/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scale"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positionYTouch2"",
                    ""id"": ""2123da21-ab8c-4370-9846-71f8da23705c"",
                    ""path"": ""<Touchscreen>/touch1/position/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scale"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Dpad
        m_Dpad = asset.FindActionMap("Dpad", throwIfNotFound: true);
        m_Dpad_Move = m_Dpad.FindAction("Move", throwIfNotFound: true);
        // Player Controls
        m_PlayerControls = asset.FindActionMap("Player Controls", throwIfNotFound: true);
        m_PlayerControls_Scale = m_PlayerControls.FindAction("Scale", throwIfNotFound: true);
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

    // Dpad
    private readonly InputActionMap m_Dpad;
    private IDpadActions m_DpadActionsCallbackInterface;
    private readonly InputAction m_Dpad_Move;
    public struct DpadActions
    {
        private @InputControls m_Wrapper;
        public DpadActions(@InputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Dpad_Move;
        public InputActionMap Get() { return m_Wrapper.m_Dpad; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DpadActions set) { return set.Get(); }
        public void SetCallbacks(IDpadActions instance)
        {
            if (m_Wrapper.m_DpadActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_DpadActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_DpadActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_DpadActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_DpadActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public DpadActions @Dpad => new DpadActions(this);

    // Player Controls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_Scale;
    public struct PlayerControlsActions
    {
        private @InputControls m_Wrapper;
        public PlayerControlsActions(@InputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Scale => m_Wrapper.m_PlayerControls_Scale;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @Scale.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnScale;
                @Scale.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnScale;
                @Scale.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnScale;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Scale.started += instance.OnScale;
                @Scale.performed += instance.OnScale;
                @Scale.canceled += instance.OnScale;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);
    public interface IDpadActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IPlayerControlsActions
    {
        void OnScale(InputAction.CallbackContext context);
    }
}
