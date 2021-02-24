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
                    ""name"": ""PointerTap"",
                    ""type"": ""Button"",
                    ""id"": ""30bf1e30-b4ea-41cf-aa21-d40e0a16b3dc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""MultiTap(tapCount=1)""
                },
                {
                    ""name"": ""PointerDoubleTap"",
                    ""type"": ""Button"",
                    ""id"": ""830b9398-7623-452c-a47b-84b2e1999544"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""MultiTap""
                },
                {
                    ""name"": ""PointerTripleTap"",
                    ""type"": ""Button"",
                    ""id"": ""c94ecf44-cd9c-43aa-b55a-817cafe4f377"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""MultiTap(tapCount=3)""
                },
                {
                    ""name"": ""PointerPosition"",
                    ""type"": ""Value"",
                    ""id"": ""6231e476-589a-49e9-b0c3-5ea1fc7a10e6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PointerPressRelease"",
                    ""type"": ""Button"",
                    ""id"": ""9115a950-ca65-4e75-bb74-9efa9c2b8240"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Scale"",
                    ""type"": ""Value"",
                    ""id"": ""aebddb12-4f78-40f5-8840-4d36676c5bab"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""InventoryDialog"",
                    ""type"": ""Button"",
                    ""id"": ""21db96df-edb8-4d63-a145-f9d38c1b29d9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SettingSkillDialog"",
                    ""type"": ""Button"",
                    ""id"": ""3fb8811e-ec8c-4a63-b60d-16808c93610b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SkillButton1"",
                    ""type"": ""Button"",
                    ""id"": ""ab107c2e-598f-4fe7-8d95-278023f15927"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SkillButton2"",
                    ""type"": ""Button"",
                    ""id"": ""8f02aedc-f161-4254-9386-cee88de3e7e4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Tap"",
                    ""type"": ""Button"",
                    ""id"": ""57811ec5-f47b-439d-bb20-7905a4eed603"",
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
                    ""action"": ""PointerTap"",
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
                    ""action"": ""PointerTap"",
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
                    ""action"": ""PointerPosition"",
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
                    ""action"": ""PointerPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""538681dc-8358-4a31-9cb9-967aedbc3201"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""PointerPressRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3c5d3dfe-e7ca-4f90-bdaf-8c4561c855e0"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""PointerPressRelease"",
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
                    ""action"": ""PointerDoubleTap"",
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
                    ""action"": ""PointerDoubleTap"",
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
                    ""action"": ""PointerTripleTap"",
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
                    ""action"": ""PointerTripleTap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a73bac55-fdf4-4ce7-9086-b9de3836f615"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scale"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a5827baa-c87e-4b24-bd26-b45974aee5d3"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""InventoryDialog"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d12b002b-e2b7-4aac-ab17-1ba22d352486"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SkillButton1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""def3f0df-e938-446d-9c52-29162a82b592"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SkillButton2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""861f8747-c396-4e4c-a958-397985aca705"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""SettingSkillDialog"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ced89237-0094-4d22-84ed-b852899bf4f1"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Universal Binding"",
                    ""id"": ""f46f3d5b-302e-45fc-b35a-f738e6e28638"",
                    ""path"": ""UniversalBinding(_amountModifiers=4,_amountResults=5)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Modifier1"",
                    ""id"": ""61847a70-ada5-4153-90db-6e8c8d78701e"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Modifier2"",
                    ""id"": ""af34078d-76a6-4a10-acf3-380b36423354"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Modifier3"",
                    ""id"": ""9dcb1d7c-40ce-48d9-bd3c-18272bd82ede"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Modifier4"",
                    ""id"": ""53be9741-35ab-494f-962e-88883136457c"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Modifier5"",
                    ""id"": ""fb159ac9-4c77-43a5-888a-8d5c35bf634f"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Modifier6"",
                    ""id"": ""9e42f61f-a2cf-4f40-b491-04906eb7da80"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Modifier7"",
                    ""id"": ""59f45fb6-0378-4599-a9b4-98892a7fc007"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Modifier8"",
                    ""id"": ""c64dd991-627d-4da0-bfec-2882963a6f20"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Modifier9"",
                    ""id"": ""02c6b777-9d35-456d-9bc3-a9ca860c9fa4"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Result1"",
                    ""id"": ""ebb2684f-f2f7-46f2-b900-f4f92e427fb6"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Result2"",
                    ""id"": ""225636ef-3525-4e26-b460-d6f1f4b87c34"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Result3"",
                    ""id"": ""5e41886d-83a8-412a-a8c5-1158578796b0"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Result4"",
                    ""id"": ""b571adca-8ee1-4461-9f37-abbe517f405d"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Result5"",
                    ""id"": ""b3532b94-f52a-43a0-b623-fd0c3a52c08e"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Result6"",
                    ""id"": ""94b8738c-bab1-4aba-a8d3-dbe4e67b7e3c"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Result7"",
                    ""id"": ""4bf4ae8c-451a-43bd-ae11-8b26be28d43b"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Result8"",
                    ""id"": ""581c1071-9936-4565-8890-c08cca146d46"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Result9"",
                    ""id"": ""869eb61f-8c32-4eff-95a4-50d783608ad6"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
            m_PlayerControls_PointerTap = m_PlayerControls.FindAction("PointerTap", throwIfNotFound: true);
            m_PlayerControls_PointerDoubleTap = m_PlayerControls.FindAction("PointerDoubleTap", throwIfNotFound: true);
            m_PlayerControls_PointerTripleTap = m_PlayerControls.FindAction("PointerTripleTap", throwIfNotFound: true);
            m_PlayerControls_PointerPosition = m_PlayerControls.FindAction("PointerPosition", throwIfNotFound: true);
            m_PlayerControls_PointerPressRelease = m_PlayerControls.FindAction("PointerPressRelease", throwIfNotFound: true);
            m_PlayerControls_Scale = m_PlayerControls.FindAction("Scale", throwIfNotFound: true);
            m_PlayerControls_InventoryDialog = m_PlayerControls.FindAction("InventoryDialog", throwIfNotFound: true);
            m_PlayerControls_SettingSkillDialog = m_PlayerControls.FindAction("SettingSkillDialog", throwIfNotFound: true);
            m_PlayerControls_SkillButton1 = m_PlayerControls.FindAction("SkillButton1", throwIfNotFound: true);
            m_PlayerControls_SkillButton2 = m_PlayerControls.FindAction("SkillButton2", throwIfNotFound: true);
            m_PlayerControls_Tap = m_PlayerControls.FindAction("Tap", throwIfNotFound: true);
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
        private readonly InputAction m_PlayerControls_PointerTap;
        private readonly InputAction m_PlayerControls_PointerDoubleTap;
        private readonly InputAction m_PlayerControls_PointerTripleTap;
        private readonly InputAction m_PlayerControls_PointerPosition;
        private readonly InputAction m_PlayerControls_PointerPressRelease;
        private readonly InputAction m_PlayerControls_Scale;
        private readonly InputAction m_PlayerControls_InventoryDialog;
        private readonly InputAction m_PlayerControls_SettingSkillDialog;
        private readonly InputAction m_PlayerControls_SkillButton1;
        private readonly InputAction m_PlayerControls_SkillButton2;
        private readonly InputAction m_PlayerControls_Tap;
        public struct PlayerControlsActions
        {
            private @PlayerActions m_Wrapper;
            public PlayerControlsActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_PlayerControls_Movement;
            public InputAction @PointerTap => m_Wrapper.m_PlayerControls_PointerTap;
            public InputAction @PointerDoubleTap => m_Wrapper.m_PlayerControls_PointerDoubleTap;
            public InputAction @PointerTripleTap => m_Wrapper.m_PlayerControls_PointerTripleTap;
            public InputAction @PointerPosition => m_Wrapper.m_PlayerControls_PointerPosition;
            public InputAction @PointerPressRelease => m_Wrapper.m_PlayerControls_PointerPressRelease;
            public InputAction @Scale => m_Wrapper.m_PlayerControls_Scale;
            public InputAction @InventoryDialog => m_Wrapper.m_PlayerControls_InventoryDialog;
            public InputAction @SettingSkillDialog => m_Wrapper.m_PlayerControls_SettingSkillDialog;
            public InputAction @SkillButton1 => m_Wrapper.m_PlayerControls_SkillButton1;
            public InputAction @SkillButton2 => m_Wrapper.m_PlayerControls_SkillButton2;
            public InputAction @Tap => m_Wrapper.m_PlayerControls_Tap;
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
                    @PointerTap.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPointerTap;
                    @PointerTap.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPointerTap;
                    @PointerTap.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPointerTap;
                    @PointerDoubleTap.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPointerDoubleTap;
                    @PointerDoubleTap.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPointerDoubleTap;
                    @PointerDoubleTap.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPointerDoubleTap;
                    @PointerTripleTap.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPointerTripleTap;
                    @PointerTripleTap.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPointerTripleTap;
                    @PointerTripleTap.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPointerTripleTap;
                    @PointerPosition.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPointerPosition;
                    @PointerPosition.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPointerPosition;
                    @PointerPosition.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPointerPosition;
                    @PointerPressRelease.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPointerPressRelease;
                    @PointerPressRelease.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPointerPressRelease;
                    @PointerPressRelease.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPointerPressRelease;
                    @Scale.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnScale;
                    @Scale.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnScale;
                    @Scale.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnScale;
                    @InventoryDialog.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInventoryDialog;
                    @InventoryDialog.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInventoryDialog;
                    @InventoryDialog.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInventoryDialog;
                    @SettingSkillDialog.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSettingSkillDialog;
                    @SettingSkillDialog.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSettingSkillDialog;
                    @SettingSkillDialog.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSettingSkillDialog;
                    @SkillButton1.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSkillButton1;
                    @SkillButton1.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSkillButton1;
                    @SkillButton1.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSkillButton1;
                    @SkillButton2.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSkillButton2;
                    @SkillButton2.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSkillButton2;
                    @SkillButton2.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSkillButton2;
                    @Tap.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnTap;
                    @Tap.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnTap;
                    @Tap.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnTap;
                }
                m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Movement.started += instance.OnMovement;
                    @Movement.performed += instance.OnMovement;
                    @Movement.canceled += instance.OnMovement;
                    @PointerTap.started += instance.OnPointerTap;
                    @PointerTap.performed += instance.OnPointerTap;
                    @PointerTap.canceled += instance.OnPointerTap;
                    @PointerDoubleTap.started += instance.OnPointerDoubleTap;
                    @PointerDoubleTap.performed += instance.OnPointerDoubleTap;
                    @PointerDoubleTap.canceled += instance.OnPointerDoubleTap;
                    @PointerTripleTap.started += instance.OnPointerTripleTap;
                    @PointerTripleTap.performed += instance.OnPointerTripleTap;
                    @PointerTripleTap.canceled += instance.OnPointerTripleTap;
                    @PointerPosition.started += instance.OnPointerPosition;
                    @PointerPosition.performed += instance.OnPointerPosition;
                    @PointerPosition.canceled += instance.OnPointerPosition;
                    @PointerPressRelease.started += instance.OnPointerPressRelease;
                    @PointerPressRelease.performed += instance.OnPointerPressRelease;
                    @PointerPressRelease.canceled += instance.OnPointerPressRelease;
                    @Scale.started += instance.OnScale;
                    @Scale.performed += instance.OnScale;
                    @Scale.canceled += instance.OnScale;
                    @InventoryDialog.started += instance.OnInventoryDialog;
                    @InventoryDialog.performed += instance.OnInventoryDialog;
                    @InventoryDialog.canceled += instance.OnInventoryDialog;
                    @SettingSkillDialog.started += instance.OnSettingSkillDialog;
                    @SettingSkillDialog.performed += instance.OnSettingSkillDialog;
                    @SettingSkillDialog.canceled += instance.OnSettingSkillDialog;
                    @SkillButton1.started += instance.OnSkillButton1;
                    @SkillButton1.performed += instance.OnSkillButton1;
                    @SkillButton1.canceled += instance.OnSkillButton1;
                    @SkillButton2.started += instance.OnSkillButton2;
                    @SkillButton2.performed += instance.OnSkillButton2;
                    @SkillButton2.canceled += instance.OnSkillButton2;
                    @Tap.started += instance.OnTap;
                    @Tap.performed += instance.OnTap;
                    @Tap.canceled += instance.OnTap;
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
            void OnPointerTap(InputAction.CallbackContext context);
            void OnPointerDoubleTap(InputAction.CallbackContext context);
            void OnPointerTripleTap(InputAction.CallbackContext context);
            void OnPointerPosition(InputAction.CallbackContext context);
            void OnPointerPressRelease(InputAction.CallbackContext context);
            void OnScale(InputAction.CallbackContext context);
            void OnInventoryDialog(InputAction.CallbackContext context);
            void OnSettingSkillDialog(InputAction.CallbackContext context);
            void OnSkillButton1(InputAction.CallbackContext context);
            void OnSkillButton2(InputAction.CallbackContext context);
            void OnTap(InputAction.CallbackContext context);
        }
    }
}
