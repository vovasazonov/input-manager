// GENERATED AUTOMATICALLY FROM 'Packages/com.kefir.input-manager/Runtime/Inputs/PlayerActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Inputs
{
    public class @PlayerActions : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerActions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActions"",
    ""maps"": [
        {
            ""name"": ""PlayerControls"",
            ""id"": ""476ef085-c1c2-4c39-838c-015fc93164b3"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""a7a2f029-fba2-46ee-8fb4-426c6c9168c3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PrimaryPointerTap"",
                    ""type"": ""Button"",
                    ""id"": ""30bf1e30-b4ea-41cf-aa21-d40e0a16b3dc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""MultiTap(tapCount=1)""
                },
                {
                    ""name"": ""PrimaryPointerDoubleTap"",
                    ""type"": ""Button"",
                    ""id"": ""830b9398-7623-452c-a47b-84b2e1999544"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""MultiTap""
                },
                {
                    ""name"": ""PrimaryPointerTripleTap"",
                    ""type"": ""Button"",
                    ""id"": ""c94ecf44-cd9c-43aa-b55a-817cafe4f377"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""MultiTap(tapCount=3)""
                },
                {
                    ""name"": ""PrimaryPointerPosition"",
                    ""type"": ""Value"",
                    ""id"": ""6231e476-589a-49e9-b0c3-5ea1fc7a10e6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pinch"",
                    ""type"": ""Value"",
                    ""id"": ""f08016df-d853-4300-bd54-604974af6b33"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Swipe"",
                    ""type"": ""Button"",
                    ""id"": ""9115a950-ca65-4e75-bb74-9efa9c2b8240"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""b1f71dcd-f2c6-4546-9b52-19a880fc52de"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0f2069a7-7518-4818-a980-af33d4981ec1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""02658600-2c9e-44de-99fc-0b808ff1dc5b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6e70a1c0-ef04-4050-ac43-cb1175fc7e66"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f9f64165-bade-4163-b6f0-5ef848a6c248"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2eb91f25-5742-4340-bb81-20e22f7b0443"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e28e4b1f-4289-4d13-81d8-7a1a8e8b115a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""PrimaryPointerTap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c648bf93-e49e-4ab3-828e-7d00c223cd9e"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""PrimaryPointerTap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e54bd23-a192-4945-a3c1-0517fb98d84f"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""PrimaryPointerPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""35a291d0-e0f6-4c1e-ba6c-efe0bf2df30c"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""PrimaryPointerPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f627d91c-149f-41f8-861e-a2ce9eb7ecee"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Pinch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""538681dc-8358-4a31-9cb9-967aedbc3201"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Swipe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82ece81f-0008-4215-bf66-584764a57e1c"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""PrimaryPointerDoubleTap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6191765c-a200-46c4-8805-1d87126e9eb0"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""PrimaryPointerDoubleTap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60a1ba46-353f-4238-8f11-f2ed0e72802a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""PrimaryPointerTripleTap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""480c44f2-542a-4fad-9fce-99039c37fc20"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""PrimaryPointerTripleTap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""PC"",
            ""bindingGroup"": ""PC"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""TouchScreen"",
            ""bindingGroup"": ""TouchScreen"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // PlayerControls
            m_PlayerControls = asset.FindActionMap("PlayerControls", throwIfNotFound: true);
            m_PlayerControls_Movement = m_PlayerControls.FindAction("Movement", throwIfNotFound: true);
            m_PlayerControls_PrimaryPointerTap = m_PlayerControls.FindAction("PrimaryPointerTap", throwIfNotFound: true);
            m_PlayerControls_PrimaryPointerDoubleTap = m_PlayerControls.FindAction("PrimaryPointerDoubleTap", throwIfNotFound: true);
            m_PlayerControls_PrimaryPointerTripleTap = m_PlayerControls.FindAction("PrimaryPointerTripleTap", throwIfNotFound: true);
            m_PlayerControls_PrimaryPointerPosition = m_PlayerControls.FindAction("PrimaryPointerPosition", throwIfNotFound: true);
            m_PlayerControls_Pinch = m_PlayerControls.FindAction("Pinch", throwIfNotFound: true);
            m_PlayerControls_Swipe = m_PlayerControls.FindAction("Swipe", throwIfNotFound: true);
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

        // PlayerControls
        private readonly InputActionMap m_PlayerControls;
        private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
        private readonly InputAction m_PlayerControls_Movement;
        private readonly InputAction m_PlayerControls_PrimaryPointerTap;
        private readonly InputAction m_PlayerControls_PrimaryPointerDoubleTap;
        private readonly InputAction m_PlayerControls_PrimaryPointerTripleTap;
        private readonly InputAction m_PlayerControls_PrimaryPointerPosition;
        private readonly InputAction m_PlayerControls_Pinch;
        private readonly InputAction m_PlayerControls_Swipe;
        public struct PlayerControlsActions
        {
            private @PlayerActions m_Wrapper;
            public PlayerControlsActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_PlayerControls_Movement;
            public InputAction @PrimaryPointerTap => m_Wrapper.m_PlayerControls_PrimaryPointerTap;
            public InputAction @PrimaryPointerDoubleTap => m_Wrapper.m_PlayerControls_PrimaryPointerDoubleTap;
            public InputAction @PrimaryPointerTripleTap => m_Wrapper.m_PlayerControls_PrimaryPointerTripleTap;
            public InputAction @PrimaryPointerPosition => m_Wrapper.m_PlayerControls_PrimaryPointerPosition;
            public InputAction @Pinch => m_Wrapper.m_PlayerControls_Pinch;
            public InputAction @Swipe => m_Wrapper.m_PlayerControls_Swipe;
            public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerControlsActions instance)
            {
                if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
                {
                    @Movement.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                    @Movement.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                    @Movement.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                    @PrimaryPointerTap.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPrimaryPointerTap;
                    @PrimaryPointerTap.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPrimaryPointerTap;
                    @PrimaryPointerTap.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPrimaryPointerTap;
                    @PrimaryPointerDoubleTap.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPrimaryPointerDoubleTap;
                    @PrimaryPointerDoubleTap.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPrimaryPointerDoubleTap;
                    @PrimaryPointerDoubleTap.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPrimaryPointerDoubleTap;
                    @PrimaryPointerTripleTap.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPrimaryPointerTripleTap;
                    @PrimaryPointerTripleTap.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPrimaryPointerTripleTap;
                    @PrimaryPointerTripleTap.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPrimaryPointerTripleTap;
                    @PrimaryPointerPosition.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPrimaryPointerPosition;
                    @PrimaryPointerPosition.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPrimaryPointerPosition;
                    @PrimaryPointerPosition.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPrimaryPointerPosition;
                    @Pinch.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPinch;
                    @Pinch.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPinch;
                    @Pinch.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPinch;
                    @Swipe.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSwipe;
                    @Swipe.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSwipe;
                    @Swipe.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSwipe;
                }
                m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Movement.started += instance.OnMovement;
                    @Movement.performed += instance.OnMovement;
                    @Movement.canceled += instance.OnMovement;
                    @PrimaryPointerTap.started += instance.OnPrimaryPointerTap;
                    @PrimaryPointerTap.performed += instance.OnPrimaryPointerTap;
                    @PrimaryPointerTap.canceled += instance.OnPrimaryPointerTap;
                    @PrimaryPointerDoubleTap.started += instance.OnPrimaryPointerDoubleTap;
                    @PrimaryPointerDoubleTap.performed += instance.OnPrimaryPointerDoubleTap;
                    @PrimaryPointerDoubleTap.canceled += instance.OnPrimaryPointerDoubleTap;
                    @PrimaryPointerTripleTap.started += instance.OnPrimaryPointerTripleTap;
                    @PrimaryPointerTripleTap.performed += instance.OnPrimaryPointerTripleTap;
                    @PrimaryPointerTripleTap.canceled += instance.OnPrimaryPointerTripleTap;
                    @PrimaryPointerPosition.started += instance.OnPrimaryPointerPosition;
                    @PrimaryPointerPosition.performed += instance.OnPrimaryPointerPosition;
                    @PrimaryPointerPosition.canceled += instance.OnPrimaryPointerPosition;
                    @Pinch.started += instance.OnPinch;
                    @Pinch.performed += instance.OnPinch;
                    @Pinch.canceled += instance.OnPinch;
                    @Swipe.started += instance.OnSwipe;
                    @Swipe.performed += instance.OnSwipe;
                    @Swipe.canceled += instance.OnSwipe;
                }
            }
        }
        public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);
        private int m_PCSchemeIndex = -1;
        public InputControlScheme PCScheme
        {
            get
            {
                if (m_PCSchemeIndex == -1) m_PCSchemeIndex = asset.FindControlSchemeIndex("PC");
                return asset.controlSchemes[m_PCSchemeIndex];
            }
        }
        private int m_TouchScreenSchemeIndex = -1;
        public InputControlScheme TouchScreenScheme
        {
            get
            {
                if (m_TouchScreenSchemeIndex == -1) m_TouchScreenSchemeIndex = asset.FindControlSchemeIndex("TouchScreen");
                return asset.controlSchemes[m_TouchScreenSchemeIndex];
            }
        }
        public interface IPlayerControlsActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnPrimaryPointerTap(InputAction.CallbackContext context);
            void OnPrimaryPointerDoubleTap(InputAction.CallbackContext context);
            void OnPrimaryPointerTripleTap(InputAction.CallbackContext context);
            void OnPrimaryPointerPosition(InputAction.CallbackContext context);
            void OnPinch(InputAction.CallbackContext context);
            void OnSwipe(InputAction.CallbackContext context);
        }
    }
}
