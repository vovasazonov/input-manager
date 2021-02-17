using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public sealed class HeavySelectable : MonoBehaviour, IHeavySelectable
    {
        private Selectable _selectable;
        [SerializeField] private List<HeavySelectable> _selectableElements;

        public IEnumerable<IHeavySelectable> SelectableElements => _selectableElements;

        void Start()
        {
            _selectable = GetComponent<Selectable>();
            CorrectNavigationElementsInSub();
        }

        private void CorrectNavigationElementsInSub()
        {
            foreach (var selectableElement in _selectableElements)
            {
                if (selectableElement._selectable.navigation.mode == Navigation.Mode.Automatic)
                {
                    var selectable = selectableElement._selectable;

                    var navigation = selectable.navigation;
                    navigation.mode = Navigation.Mode.Explicit;

                    FixNavigation(() => selectable.FindSelectableOnUp(), selectableObj => navigation.selectOnUp = selectableObj);
                    FixNavigation(() => selectable.FindSelectableOnDown(), selectableObj => navigation.selectOnDown = selectableObj);
                    FixNavigation(() => selectable.FindSelectableOnLeft(), selectableObj => navigation.selectOnLeft = selectableObj);
                    FixNavigation(() => selectable.FindSelectableOnRight(), selectableObj => navigation.selectOnRight = selectableObj);

                    selectable.navigation = navigation;
                }
            }
        }

        private void FixNavigation(Func<Selectable> getSelectable, Action<Selectable> setSelectableDelegate)
        {
            var checkingSelectable = getSelectable.Invoke();
            
            if (IsNavigationElementInSub(checkingSelectable))
            {
                setSelectableDelegate.Invoke(checkingSelectable);
            }
            else
            {
                setSelectableDelegate.Invoke(null);
            }
        }
        
        private bool IsNavigationElementInSub(Selectable navigateTo)
        {
            return _selectableElements.Select(i => i._selectable).Contains(navigateTo);
        }
    }
}