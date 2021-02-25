using System;
using System.Collections.Generic;
using UnityEngine.InputSystem;

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
}