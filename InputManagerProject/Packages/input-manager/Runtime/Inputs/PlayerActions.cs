// GENERATED AUTOMATICALLY FROM 'Packages/com.kefir.input-manager/Runtime/Inputs/PlayerActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;
using Object = UnityEngine.Object;

namespace Inputs
{
    public class PlayerActions : IInputActionCollection, IDisposable
    {
        // PlayerControls
        private readonly InputActionMap m_PlayerControls;

        private readonly InputAction m_PlayerControls_InventoryDialog;

        private readonly InputAction m_PlayerControls_Movement;

        private readonly InputAction m_PlayerControls_Pinch;

        private readonly InputAction m_PlayerControls_Scroll;

        private readonly InputAction m_PlayerControls_SettingSkillDialog;

        private readonly InputAction m_PlayerControls_SkillButton1;

        private readonly InputAction m_PlayerControls_SkillButton2;

        private readonly InputAction m_PlayerControls_Swipe;

        private readonly InputAction m_PlayerControls_Tap;

        private int m_PCSchemeIndex = -1;

        private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;

        private int m_TouchScreenSchemeIndex = -1;

        public InputActionAsset asset { get; }
        public PlayerControlsActions PlayerControls => new PlayerControlsActions(this);

        public InputControlScheme PCScheme
        {
            get
            {
                if (m_PCSchemeIndex == -1) m_PCSchemeIndex = asset.FindControlSchemeIndex("PC");
                return asset.controlSchemes[m_PCSchemeIndex];
            }
        }

        public InputControlScheme TouchScreenScheme
        {
            get
            {
                if (m_TouchScreenSchemeIndex == -1) m_TouchScreenSchemeIndex = asset.FindControlSchemeIndex("TouchScreen");
                return asset.controlSchemes[m_TouchScreenSchemeIndex];
            }
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

        public PlayerActions()
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
                },
                {
                    ""name"": ""Swipe"",
                    ""type"": ""Button"",
                    ""id"": ""16cfed38-1028-4b78-a677-269b61048701"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Scroll"",
                    ""type"": ""Value"",
                    ""id"": ""32cda967-b65f-4c04-81d7-9e5d2bbfb6ad"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pinch"",
                    ""type"": ""Button"",
                    ""id"": ""3173da29-2e8e-4751-a78f-d5d3b164f39c"",
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
                    ""name"": ""LeftButton"",
                    ""id"": ""baa582bb-b219-488c-9447-6cc289fa1e5e"",
                    ""path"": ""UniversalBinding(AmountModifiers=1)"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Modifier1"",
                    ""id"": ""0b29ee0f-b448-4ad0-a052-6b1f97cff7c9"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Result1"",
                    ""id"": ""3b69db01-8627-4297-86a5-a6a16ef11a41"",
                    ""path"": ""<Mouse>/position/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Result2"",
                    ""id"": ""930da51c-052c-449e-93bd-8cf3756cd629"",
                    ""path"": ""<Mouse>/position/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Result3"",
                    ""id"": ""f8234826-063f-4e4c-b2d4-05b1428ebfe7"",
                    ""path"": ""<Mouse>/clickCount"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""TouchTap"",
                    ""id"": ""7c479dc4-84fb-4315-853c-150565335c06"",
                    ""path"": ""UniversalBinding(AmountModifiers=1)"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Modifier1"",
                    ""id"": ""c6e97a13-2196-4283-aaf4-e08c4fdb372e"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Result1"",
                    ""id"": ""ec8d8806-34df-494a-9643-41732458fb75"",
                    ""path"": ""<Touchscreen>/primaryTouch/position/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Result2"",
                    ""id"": ""e18cd48c-0c92-4840-8ee3-f0fefdf6d338"",
                    ""path"": ""<Touchscreen>/primaryTouch/position/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Result3"",
                    ""id"": ""624b2b82-54d5-44b7-86f4-7b94ddcde737"",
                    ""path"": ""<Touchscreen>/primaryTouch/tapCount"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""PcSwipe"",
                    ""id"": ""5e2b36b9-fcb5-4c0a-9e60-2a2338663d85"",
                    ""path"": ""UniversalBinding(AmountModifiers=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Swipe"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Modifier1"",
                    ""id"": ""db3a1b22-5eb2-4173-a71b-170d190c509a"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Swipe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Result1"",
                    ""id"": ""4a6a2575-e355-4f3c-8e87-c98070b14df3"",
                    ""path"": ""<Mouse>/position/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Swipe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Result2"",
                    ""id"": ""e0d61b37-a956-4d35-9590-06ddf5001e6b"",
                    ""path"": ""<Mouse>/position/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Swipe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""TouchSwipe"",
                    ""id"": ""5b341caf-b888-489c-b9e7-ca343066fa6d"",
                    ""path"": ""UniversalBinding(AmountModifiers=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Swipe"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Modifier1"",
                    ""id"": ""f318fd93-53da-4eb7-b9a4-09b74b737347"",
                    ""path"": ""<Touchscreen>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""Swipe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Result1"",
                    ""id"": ""32808420-b854-4b9c-9818-834e1c73d80b"",
                    ""path"": ""<Touchscreen>/primaryTouch/position/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""Swipe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Result2"",
                    ""id"": ""ef93fcbf-0ca8-47fb-9628-4b2a177906a8"",
                    ""path"": ""<Touchscreen>/primaryTouch/position/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""Swipe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""75d50cf6-a940-4180-85ef-481789c34d4a"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Pinch"",
                    ""id"": ""efb0c4fd-e9a4-49db-9005-940a5b855038"",
                    ""path"": ""UniversalBinding(AmountModifiers=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pinch"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Modifier1"",
                    ""id"": ""01531480-f554-449a-a576-f5ff88f5b9c8"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""Pinch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Modifier2"",
                    ""id"": ""72f93403-dcbd-40de-a580-5411a1cdd361"",
                    ""path"": ""<Touchscreen>/touch1/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""Pinch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Result1"",
                    ""id"": ""f1c0c880-092e-4de1-97a5-c1bcda068688"",
                    ""path"": ""<Touchscreen>/primaryTouch/position/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""Pinch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Result2"",
                    ""id"": ""34fd31a6-ca6b-4b75-9ee5-5d34de37429b"",
                    ""path"": ""<Touchscreen>/primaryTouch/position/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""Pinch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Result3"",
                    ""id"": ""c2c63af3-a4e6-4c69-9af1-fd4a154d1b07"",
                    ""path"": ""<Touchscreen>/touch1/position/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""Pinch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Result4"",
                    ""id"": ""36e22757-74fe-4dbd-bf88-d768259b2de8"",
                    ""path"": ""<Touchscreen>/touch1/position/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchScreen"",
                    ""action"": ""Pinch"",
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
            m_PlayerControls = asset.FindActionMap("PlayerControls", true);
            m_PlayerControls_Movement = m_PlayerControls.FindAction("Movement", true);
            m_PlayerControls_InventoryDialog = m_PlayerControls.FindAction("InventoryDialog", true);
            m_PlayerControls_SettingSkillDialog = m_PlayerControls.FindAction("SettingSkillDialog", true);
            m_PlayerControls_SkillButton1 = m_PlayerControls.FindAction("SkillButton1", true);
            m_PlayerControls_SkillButton2 = m_PlayerControls.FindAction("SkillButton2", true);
            m_PlayerControls_Tap = m_PlayerControls.FindAction("Tap", true);
            m_PlayerControls_Swipe = m_PlayerControls.FindAction("Swipe", true);
            m_PlayerControls_Scroll = m_PlayerControls.FindAction("Scroll", true);
            m_PlayerControls_Pinch = m_PlayerControls.FindAction("Pinch", true);
        }

        public void Dispose()
        {
            Object.Destroy(asset);
        }

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

        public struct PlayerControlsActions
        {
            private readonly PlayerActions m_Wrapper;

            public PlayerControlsActions(PlayerActions wrapper)
            {
                m_Wrapper = wrapper;
            }

            public InputAction Movement => m_Wrapper.m_PlayerControls_Movement;
            public InputAction InventoryDialog => m_Wrapper.m_PlayerControls_InventoryDialog;
            public InputAction SettingSkillDialog => m_Wrapper.m_PlayerControls_SettingSkillDialog;
            public InputAction SkillButton1 => m_Wrapper.m_PlayerControls_SkillButton1;
            public InputAction SkillButton2 => m_Wrapper.m_PlayerControls_SkillButton2;
            public InputAction Tap => m_Wrapper.m_PlayerControls_Tap;
            public InputAction Swipe => m_Wrapper.m_PlayerControls_Swipe;
            public InputAction Scroll => m_Wrapper.m_PlayerControls_Scroll;
            public InputAction Pinch => m_Wrapper.m_PlayerControls_Pinch;

            public InputActionMap Get()
            {
                return m_Wrapper.m_PlayerControls;
            }

            public void Enable()
            {
                Get().Enable();
            }

            public void Disable()
            {
                Get().Disable();
            }

            public bool enabled => Get().enabled;

            public static implicit operator InputActionMap(PlayerControlsActions set)
            {
                return set.Get();
            }

            public void SetCallbacks(IPlayerControlsActions instance)
            {
                if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
                {
                    Movement.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                    Movement.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                    Movement.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                    InventoryDialog.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInventoryDialog;
                    InventoryDialog.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInventoryDialog;
                    InventoryDialog.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInventoryDialog;
                    SettingSkillDialog.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSettingSkillDialog;
                    SettingSkillDialog.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSettingSkillDialog;
                    SettingSkillDialog.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSettingSkillDialog;
                    SkillButton1.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSkillButton1;
                    SkillButton1.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSkillButton1;
                    SkillButton1.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSkillButton1;
                    SkillButton2.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSkillButton2;
                    SkillButton2.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSkillButton2;
                    SkillButton2.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSkillButton2;
                    Tap.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnTap;
                    Tap.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnTap;
                    Tap.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnTap;
                    Swipe.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSwipe;
                    Swipe.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSwipe;
                    Swipe.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSwipe;
                    Scroll.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnScroll;
                    Scroll.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnScroll;
                    Scroll.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnScroll;
                    Pinch.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPinch;
                    Pinch.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPinch;
                    Pinch.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPinch;
                }

                m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
                if (instance != null)
                {
                    Movement.started += instance.OnMovement;
                    Movement.performed += instance.OnMovement;
                    Movement.canceled += instance.OnMovement;
                    InventoryDialog.started += instance.OnInventoryDialog;
                    InventoryDialog.performed += instance.OnInventoryDialog;
                    InventoryDialog.canceled += instance.OnInventoryDialog;
                    SettingSkillDialog.started += instance.OnSettingSkillDialog;
                    SettingSkillDialog.performed += instance.OnSettingSkillDialog;
                    SettingSkillDialog.canceled += instance.OnSettingSkillDialog;
                    SkillButton1.started += instance.OnSkillButton1;
                    SkillButton1.performed += instance.OnSkillButton1;
                    SkillButton1.canceled += instance.OnSkillButton1;
                    SkillButton2.started += instance.OnSkillButton2;
                    SkillButton2.performed += instance.OnSkillButton2;
                    SkillButton2.canceled += instance.OnSkillButton2;
                    Tap.started += instance.OnTap;
                    Tap.performed += instance.OnTap;
                    Tap.canceled += instance.OnTap;
                    Swipe.started += instance.OnSwipe;
                    Swipe.performed += instance.OnSwipe;
                    Swipe.canceled += instance.OnSwipe;
                    Scroll.started += instance.OnScroll;
                    Scroll.performed += instance.OnScroll;
                    Scroll.canceled += instance.OnScroll;
                    Pinch.started += instance.OnPinch;
                    Pinch.performed += instance.OnPinch;
                    Pinch.canceled += instance.OnPinch;
                }
            }
        }

        public interface IPlayerControlsActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnInventoryDialog(InputAction.CallbackContext context);
            void OnSettingSkillDialog(InputAction.CallbackContext context);
            void OnSkillButton1(InputAction.CallbackContext context);
            void OnSkillButton2(InputAction.CallbackContext context);
            void OnTap(InputAction.CallbackContext context);
            void OnSwipe(InputAction.CallbackContext context);
            void OnScroll(InputAction.CallbackContext context);
            void OnPinch(InputAction.CallbackContext context);
        }
    }
}