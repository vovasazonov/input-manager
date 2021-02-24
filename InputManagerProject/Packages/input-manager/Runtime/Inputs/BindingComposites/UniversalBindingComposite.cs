using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
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
        [InputControl] public int Result1;
        [InputControl] public int Result2;
        [InputControl] public int Result3;
        [InputControl] public int Result4;
        [InputControl] public int Result5;

        private List<int> _modifiers;
        private List<int> _results;
        private readonly Dictionary<int, int> _takePartModifiers = new Dictionary<int, int>();
        private readonly Dictionary<int, int> _takePartResults = new Dictionary<int, int>();

        public int AmountTakePartModifiers;
        public int AmountTakePartResults;

        [InitializeOnEnterPlayMode]
        private void Initialize()
        {
            InitializeModifiers();
            InitializeResults();
            InitializeTakePartModifiers();
            InitializeTakePartResults();
        }

        static UniversalBindingComposite()
        {
            InputSystem.RegisterBindingComposite<UniversalBindingComposite>();
        }

        [RuntimeInitializeOnLoadMethod]
        static void Init()
        {
        }

        public override CompositeData ReadValue(ref InputBindingCompositeContext context)
        {
            if (IsAllModifiersPerformed(ref context))
            {
                return new CompositeData(_takePartResults, ref context);
            }

            return default;
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
            InitializeTakePartValues(_takePartModifiers, _modifiers, AmountTakePartModifiers);
        }

        private void InitializeTakePartResults()
        {
            InitializeTakePartValues(_takePartResults, _results, AmountTakePartResults);
        }

        private void InitializeTakePartValues(IDictionary<int, int> takePartValues, IList<int> values, int amountValues)
        {
            takePartValues.Clear();

            for (int i = 0; i < amountValues; i++)
            {
                takePartValues.Add(i, values[i]);
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