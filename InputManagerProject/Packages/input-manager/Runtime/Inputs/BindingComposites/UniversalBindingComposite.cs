using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Layouts;

namespace Inputs.BindingComposites
{
    public struct CompositeData : ICompositeData
    {
        private readonly IReadOnlyDictionary<int, int> _elements;
        private InputBindingCompositeContext _context;

        public TValue ReadValue<TValue>(int elementNumber) where TValue : struct, IComparable<TValue>
        {
            var idElement = _elements[elementNumber];
            return _context.ReadValue<TValue>(idElement);
        }

        public CompositeData(IReadOnlyDictionary<int, int> elements, ref InputBindingCompositeContext context)
        {
            _elements = elements;
            _context = context;
        }
    }

    public interface ICompositeData
    {
        TValue ReadValue<TValue>(int elementNumber) where TValue : struct, IComparable<TValue>;
    }

#if UNITY_EDITOR
    [InitializeOnLoad]
#endif
    public class UniversalBindingComposite : InputBindingComposite<CompositeData>
    {
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

        private List<int> _modifiers;
        private List<int> _results;
        private Dictionary<int, int> _takePartModifiers;
        private Dictionary<int, int> _takePartResults;
        private bool _isInitialized;

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

        public override CompositeData ReadValue(ref InputBindingCompositeContext context)
        {
            Initialize();
            return new CompositeData(_takePartResults, ref context);
        }

        public override float EvaluateMagnitude(ref InputBindingCompositeContext context)
        {
            Initialize();
            if (IsAllModifiersPerformed(ref context))
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
                if (context.ReadValueAsButton(takePartModifier))
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
                
                for (int i = 0; i < _modifiers.Count; i++)
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