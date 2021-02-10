using System;
using Inputs;
using UnityEngine;
using UnityEngine.UI;

namespace Samples
{
    public sealed class PointView : MonoBehaviour, IPointView
    {
        [SerializeField] private Image _image;
        [SerializeField] private RectTransform _pointRectTransform;
        [SerializeField] private Text _amountTapText;

        public void SetPosition(IVector2 position)
        {
            var pointPosition = _pointRectTransform.position;
            _pointRectTransform.position = new Vector3(position.X, position.Y, pointPosition.z);
        }

        public void SetNumber(int amount)
        {
            _amountTapText.text = amount.ToString();
        }

        public void SetColor(PointColor pointColor)
        {
            switch (pointColor)
            {
                case PointColor.Red:
                    _image.color = Color.red;
                    break;
                case PointColor.Blue:
                    _image.color = Color.blue;
                    break;
                case PointColor.Green:
                    _image.color = Color.green;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(pointColor), pointColor, null);
            }
        }
    }
}