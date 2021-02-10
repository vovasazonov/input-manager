using Inputs;
using UnityEngine;
using UnityEngine.UI;

namespace Samples
{
    public sealed class PointClickView : MonoBehaviour, IPointClickView
    {
        [SerializeField] private RectTransform _pointRectTransform;
        [SerializeField] private Text _amountTapText;

        public void SetPosition(IVector2 position)
        {
            var pointPosition = _pointRectTransform.position;
            _pointRectTransform.position = new Vector3(position.X, position.Y, pointPosition.z);
        }

        public void SetAmountTap(int amount)
        {
            _amountTapText.text = amount.ToString();
        }
    }
}