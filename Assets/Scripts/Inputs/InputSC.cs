//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/Scripts/Inputs/InputSC.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputSC: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputSC()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSC"",
    ""maps"": [
        {
            ""name"": ""Action Map"",
            ""id"": ""3d1ea6d4-af59-4c59-bca1-50861b73820f"",
            ""actions"": [
                {
                    ""name"": ""MovementAction"",
                    ""type"": ""Value"",
                    ""id"": ""2dc2fd32-96b5-4b15-a46d-9b1ceff025cf"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""JumpAction"",
                    ""type"": ""Button"",
                    ""id"": ""7b2d1660-95dc-4901-84d4-2cd18c6f2678"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""ebbb8963-93b5-4074-b483-12ae96838eab"",
                    ""path"": ""3DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementAction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e50041a8-2f34-4321-832b-202dc8157e4b"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""97c23260-556c-496a-b42a-d0d291890f7a"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3ff323c6-37f2-4285-8dd5-9309fdf3b979"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fb2c9fe6-4642-4a04-b6e1-2ec11ec01dc1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""forward"",
                    ""id"": ""d3eadeef-1ca3-4306-8d48-048dfd298aff"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""backward"",
                    ""id"": ""b23a838a-727a-48a0-beaa-4b95423223c4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""66ea70a8-584d-453c-936f-fafa576954b2"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JumpAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Control Scheme"",
            ""bindingGroup"": ""Control Scheme"",
            ""devices"": []
        }
    ]
}");
        // Action Map
        m_ActionMap = asset.FindActionMap("Action Map", throwIfNotFound: true);
        m_ActionMap_MovementAction = m_ActionMap.FindAction("MovementAction", throwIfNotFound: true);
        m_ActionMap_JumpAction = m_ActionMap.FindAction("JumpAction", throwIfNotFound: true);
    }

    ~@InputSC()
    {
        UnityEngine.Debug.Assert(!m_ActionMap.enabled, "This will cause a leak and performance issues, InputSC.ActionMap.Disable() has not been called.");
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Action Map
    private readonly InputActionMap m_ActionMap;
    private List<IActionMapActions> m_ActionMapActionsCallbackInterfaces = new List<IActionMapActions>();
    private readonly InputAction m_ActionMap_MovementAction;
    private readonly InputAction m_ActionMap_JumpAction;
    public struct ActionMapActions
    {
        private @InputSC m_Wrapper;
        public ActionMapActions(@InputSC wrapper) { m_Wrapper = wrapper; }
        public InputAction @MovementAction => m_Wrapper.m_ActionMap_MovementAction;
        public InputAction @JumpAction => m_Wrapper.m_ActionMap_JumpAction;
        public InputActionMap Get() { return m_Wrapper.m_ActionMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionMapActions set) { return set.Get(); }
        public void AddCallbacks(IActionMapActions instance)
        {
            if (instance == null || m_Wrapper.m_ActionMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ActionMapActionsCallbackInterfaces.Add(instance);
            @MovementAction.started += instance.OnMovementAction;
            @MovementAction.performed += instance.OnMovementAction;
            @MovementAction.canceled += instance.OnMovementAction;
            @JumpAction.started += instance.OnJumpAction;
            @JumpAction.performed += instance.OnJumpAction;
            @JumpAction.canceled += instance.OnJumpAction;
        }

        private void UnregisterCallbacks(IActionMapActions instance)
        {
            @MovementAction.started -= instance.OnMovementAction;
            @MovementAction.performed -= instance.OnMovementAction;
            @MovementAction.canceled -= instance.OnMovementAction;
            @JumpAction.started -= instance.OnJumpAction;
            @JumpAction.performed -= instance.OnJumpAction;
            @JumpAction.canceled -= instance.OnJumpAction;
        }

        public void RemoveCallbacks(IActionMapActions instance)
        {
            if (m_Wrapper.m_ActionMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IActionMapActions instance)
        {
            foreach (var item in m_Wrapper.m_ActionMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ActionMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ActionMapActions @ActionMap => new ActionMapActions(this);
    private int m_ControlSchemeSchemeIndex = -1;
    public InputControlScheme ControlSchemeScheme
    {
        get
        {
            if (m_ControlSchemeSchemeIndex == -1) m_ControlSchemeSchemeIndex = asset.FindControlSchemeIndex("Control Scheme");
            return asset.controlSchemes[m_ControlSchemeSchemeIndex];
        }
    }
    public interface IActionMapActions
    {
        void OnMovementAction(InputAction.CallbackContext context);
        void OnJumpAction(InputAction.CallbackContext context);
    }
}
