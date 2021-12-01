// GENERATED AUTOMATICALLY FROM 'Assets/Input Actions/Controls.inputactions'

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
            ""name"": ""Player"",
            ""id"": ""5150cde4-b1eb-4114-9d61-6f0f1c66768a"",
            ""actions"": [
                {
                    ""name"": ""MouseX"",
                    ""type"": ""Value"",
                    ""id"": ""ec290662-f7f2-4afb-8ee2-e51f979aa75b"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseY"",
                    ""type"": ""Value"",
                    ""id"": ""c700b242-f1e9-4ed9-b5ea-9473750275b3"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StickX"",
                    ""type"": ""Value"",
                    ""id"": ""393f2057-6d32-4ad1-9e41-dbe3bb1eac23"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StickY"",
                    ""type"": ""Value"",
                    ""id"": ""f29a3b98-3e97-4a7b-b153-35add51fac94"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveX"",
                    ""type"": ""Value"",
                    ""id"": ""e0633e16-c540-429c-a949-3c99426c3422"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveZ"",
                    ""type"": ""Value"",
                    ""id"": ""b8019f18-e35f-4780-a7d9-a235003c7352"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""53ca01dd-58c3-4191-a7d0-e3ff8bb492af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeResolution"",
                    ""type"": ""Button"",
                    ""id"": ""b32f4050-bae7-4bd3-ad39-d06fa7a56ea4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""60cf1166-07b7-45aa-a742-fab9e53146ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeItemLeft"",
                    ""type"": ""Button"",
                    ""id"": ""1dae9664-a61f-42a0-a08f-fb8b2ab3ba0f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeItemRight"",
                    ""type"": ""Button"",
                    ""id"": ""8aa250a9-29de-447b-a132-da7eac8ae7e8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""dcdd4ef3-1cc8-4d3e-bcfc-a39ad219319d"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""255ef263-5522-41d4-b041-3b7e347e5d60"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""91aa4076-54d4-4d6e-81c5-335f5d3a736c"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""StickX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ee55d3f-8105-4c28-b64e-e2ad6938775f"",
                    ""path"": ""<Gamepad>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""StickY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9babdcc6-4b8b-463a-8054-ed6c3bd3b1c0"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""d4aa4c51-a986-433b-b88d-830f273cf7d7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""22eb1810-1b2b-42dd-aec5-012f35fa71ed"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""fb145a70-1267-48ee-af1b-cb8829e030d2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b1ca840f-0ce1-4130-b42c-2429b570b2a9"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""8766f600-b9cd-4192-bda7-50a2eb54b437"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveZ"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""0fea3bd4-3011-43ee-b7e9-60d005e43333"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""13124fe5-f992-4971-9e4e-98b26edb94aa"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""187e2a42-7424-475d-bc69-72e0664cc57f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e3f2696-3b69-4f63-b342-bec447881148"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3a1aec9f-b9ca-44d5-9472-b619cc61ba0a"",
                    ""path"": ""<Keyboard>/backquote"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ChangeResolution"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""062bf085-eebd-4ba3-9b5f-1a13d756d4c7"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ChangeResolution"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c153c753-5328-4ab0-b731-f07b9189ec59"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aaf67246-c18e-4868-ac00-a81b43552f33"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f5e8208-fa4a-4536-9be2-ed4cb7532374"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ChangeItemLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""65c9f050-0b1f-462d-b64e-722675ce976b"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ChangeItemLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7bbbd99c-623a-4e63-9b66-3f5bfdcd6937"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ChangeItemRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0bde2c8a-045e-4ded-a54e-3defc7e9830f"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ChangeItemRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": []
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": []
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_MouseX = m_Player.FindAction("MouseX", throwIfNotFound: true);
        m_Player_MouseY = m_Player.FindAction("MouseY", throwIfNotFound: true);
        m_Player_StickX = m_Player.FindAction("StickX", throwIfNotFound: true);
        m_Player_StickY = m_Player.FindAction("StickY", throwIfNotFound: true);
        m_Player_MoveX = m_Player.FindAction("MoveX", throwIfNotFound: true);
        m_Player_MoveZ = m_Player.FindAction("MoveZ", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_ChangeResolution = m_Player.FindAction("ChangeResolution", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_ChangeItemLeft = m_Player.FindAction("ChangeItemLeft", throwIfNotFound: true);
        m_Player_ChangeItemRight = m_Player.FindAction("ChangeItemRight", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_MouseX;
    private readonly InputAction m_Player_MouseY;
    private readonly InputAction m_Player_StickX;
    private readonly InputAction m_Player_StickY;
    private readonly InputAction m_Player_MoveX;
    private readonly InputAction m_Player_MoveZ;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_ChangeResolution;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_ChangeItemLeft;
    private readonly InputAction m_Player_ChangeItemRight;
    public struct PlayerActions
    {
        private @Controls m_Wrapper;
        public PlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MouseX => m_Wrapper.m_Player_MouseX;
        public InputAction @MouseY => m_Wrapper.m_Player_MouseY;
        public InputAction @StickX => m_Wrapper.m_Player_StickX;
        public InputAction @StickY => m_Wrapper.m_Player_StickY;
        public InputAction @MoveX => m_Wrapper.m_Player_MoveX;
        public InputAction @MoveZ => m_Wrapper.m_Player_MoveZ;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @ChangeResolution => m_Wrapper.m_Player_ChangeResolution;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @ChangeItemLeft => m_Wrapper.m_Player_ChangeItemLeft;
        public InputAction @ChangeItemRight => m_Wrapper.m_Player_ChangeItemRight;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @MouseX.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseX;
                @MouseX.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseX;
                @MouseX.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseX;
                @MouseY.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseY;
                @MouseY.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseY;
                @MouseY.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseY;
                @StickX.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStickX;
                @StickX.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStickX;
                @StickX.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStickX;
                @StickY.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStickY;
                @StickY.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStickY;
                @StickY.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStickY;
                @MoveX.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveX;
                @MoveX.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveX;
                @MoveX.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveX;
                @MoveZ.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveZ;
                @MoveZ.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveZ;
                @MoveZ.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveZ;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @ChangeResolution.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeResolution;
                @ChangeResolution.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeResolution;
                @ChangeResolution.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeResolution;
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @ChangeItemLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeItemLeft;
                @ChangeItemLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeItemLeft;
                @ChangeItemLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeItemLeft;
                @ChangeItemRight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeItemRight;
                @ChangeItemRight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeItemRight;
                @ChangeItemRight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeItemRight;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MouseX.started += instance.OnMouseX;
                @MouseX.performed += instance.OnMouseX;
                @MouseX.canceled += instance.OnMouseX;
                @MouseY.started += instance.OnMouseY;
                @MouseY.performed += instance.OnMouseY;
                @MouseY.canceled += instance.OnMouseY;
                @StickX.started += instance.OnStickX;
                @StickX.performed += instance.OnStickX;
                @StickX.canceled += instance.OnStickX;
                @StickY.started += instance.OnStickY;
                @StickY.performed += instance.OnStickY;
                @StickY.canceled += instance.OnStickY;
                @MoveX.started += instance.OnMoveX;
                @MoveX.performed += instance.OnMoveX;
                @MoveX.canceled += instance.OnMoveX;
                @MoveZ.started += instance.OnMoveZ;
                @MoveZ.performed += instance.OnMoveZ;
                @MoveZ.canceled += instance.OnMoveZ;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @ChangeResolution.started += instance.OnChangeResolution;
                @ChangeResolution.performed += instance.OnChangeResolution;
                @ChangeResolution.canceled += instance.OnChangeResolution;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @ChangeItemLeft.started += instance.OnChangeItemLeft;
                @ChangeItemLeft.performed += instance.OnChangeItemLeft;
                @ChangeItemLeft.canceled += instance.OnChangeItemLeft;
                @ChangeItemRight.started += instance.OnChangeItemRight;
                @ChangeItemRight.performed += instance.OnChangeItemRight;
                @ChangeItemRight.canceled += instance.OnChangeItemRight;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMouseX(InputAction.CallbackContext context);
        void OnMouseY(InputAction.CallbackContext context);
        void OnStickX(InputAction.CallbackContext context);
        void OnStickY(InputAction.CallbackContext context);
        void OnMoveX(InputAction.CallbackContext context);
        void OnMoveZ(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnChangeResolution(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnChangeItemLeft(InputAction.CallbackContext context);
        void OnChangeItemRight(InputAction.CallbackContext context);
    }
}
