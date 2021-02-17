using UnityEngine.UI;

namespace UI
{
    public sealed class UnitySelectable : ISelectable
    {
        public event UpdatedHandler Updated;
        
        private readonly Selectable _selectable;

        public UnitySelectable(Selectable selectable)
        {
            _selectable = selectable;
        }

        private void CallUpdated()
        {
            Updated?.Invoke();
        }
    }
}