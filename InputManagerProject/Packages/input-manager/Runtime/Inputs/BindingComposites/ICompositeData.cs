using System;

namespace Inputs.BindingComposites
{
    public interface ICompositeData
    {
        TValue ReadValue<TValue>(int elementNumber) where TValue : struct, IComparable<TValue>;
    }
}