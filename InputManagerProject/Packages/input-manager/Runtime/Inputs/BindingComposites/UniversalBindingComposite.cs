using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Layouts;

namespace Inputs.BindingComposites
{
#if UNITY_EDITOR
    [InitializeOnLoad]
#endif
    public class UniversalBindingComposite : InputBindingComposite<CompositeData>
    {
        private List<int> _modifiers;
        private List<int> _results;
        private Dictionary<int, int> _takePartModifiers;
        private Dictionary<int, int> _takePartResults;
        private bool _isInitialized;
        
        [InputControl(layout = "Button")] public int Modifier1;
        [InputControl(layout = "Button")] public int Modifier2;
        [InputControl(layout = "Button")] public int Modifier3;
        [InputControl(layout = "Button")] public int Modifier4;
        [InputControl(layout = "Button")] public int Modifier5;
        [InputControl(layout = "Button")] public int Result1;
        [InputControl(layout = "Button")] public int Result2;
        [InputControl(layout = "Button")] public int Result3;
        [InputControl(layout = "Button")] public int Result4;
        [InputControl(layout = "Button")] public int Result5;

        public int AmountModifiers;

        private void Initialize()
        {
            if (!_isInitialized)
            {
                InitializeModifiers();
                InitializeResults();
                InitializeTakePartModifiers();
                InitializeTakePartResults();

                _isInitialized = true;
            }
        }

        static UniversalBindingComposite()
        {
            InputSystem.RegisterBindingComposite<UniversalBindingComposite>();
        }
        
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Init()
        {
            InputSystem.RegisterBindingComposite<UniversalBindingComposite>();
        }

        public override CompositeData ReadValue(ref InputBindingCompositeContext context)
        {
            return new CompositeData(_takePartResults, ref context);
        }

        public override float EvaluateMagnitude(ref InputBindingCompositeContext context)
        {
            Initialize();
            if (!IsAllModifiersPerformed(ref context))
            {
                return 0;
            }

            return -1;
        }
        
        private bool IsAllModifiersPerformed(ref InputBindingCompositeContext context)
        {
            bool isAllModifiersPerformed = true;

            foreach (var takePartModifier in _takePartModifiers.Values)
            {
                if (!context.ReadValueAsButton(takePartModifier))
                {
                    isAllModifiersPerformed = false;
                }
            }

            return isAllModifiersPerformed;
        }
        
        private void InitializeTakePartModifiers()
        {
            if (_takePartModifiers == null)
            {
                _takePartModifiers = new Dictionary<int, int>();
                
                for (int i = 0; i < AmountModifiers; i++)
                {
                    _takePartModifiers.Add(i, _modifiers[i]);
                }
            }
        }

        private void InitializeTakePartResults()
        {
            if (_takePartResults == null)
            {
                _takePartResults = new Dictionary<int, int>();
                
                for (int i = 0; i < _results.Count; i++)
                {
                    _takePartResults.Add(i, _results[i]);
                }
            }
        }

        private void InitializeResults()
        {
            if (_results == null)
            {
                _results = new List<int>
                {
                    Result1,
                    Result2,
                    Result3,
                    Result4,
                    Result5
                };
            }
        }

        private void InitializeModifiers()
        {
            if (_modifiers == null)
            {
                _modifiers = new List<int>
                {
                    Modifier1,
                    Modifier2,
                    Modifier3,
                    Modifier4,
                    Modifier5
                };
            }
        }
    }
}