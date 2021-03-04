﻿using Inputs;

namespace Samples
{
    public sealed class PointPresenter : IPresenter
    {
        private readonly IPointModel _model;
        private readonly IPointView _view;

        public PointPresenter(IPointView view, IPointModel model)
        {
            _view = view;
            _model = model;
        }

        public void Activate()
        {
            _model.ColorChanged += OnColorChanged;
            _model.NumberChanged += OnNumberChanged;
            _model.PositionChanged += OnPositionChanged;
            _model.Scaled += OnScaled;
        }

        public void Deactivate()
        {
            _model.ColorChanged -= OnColorChanged;
            _model.NumberChanged -= OnNumberChanged;
            _model.PositionChanged -= OnPositionChanged;
            _model.Scaled -= OnScaled;
        }

        private void OnScaled(float scale)
        {
            _view.ChangeScale(scale);
        }

        private void OnPositionChanged(IVector2 position)
        {
            _view.SetPosition(position);
        }

        private void OnNumberChanged(int number)
        {
            _view.SetNumber(number);
        }

        private void OnColorChanged(PointColor pointColor)
        {
            _view.SetColor(pointColor);
        }
    }
}