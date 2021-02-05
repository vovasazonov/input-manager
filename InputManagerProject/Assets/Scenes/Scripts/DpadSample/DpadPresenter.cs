using System;

namespace Scenes.Scripts.DpadSample
{
    public class DpadPresenter
    {
        private readonly IDpadCoordinatesView _view;
        private readonly IDpadModel _model;

        public DpadPresenter(IDpadCoordinatesView view, IDpadModel model)
        {
            _view = view;
            _model = model;
        }

        public void Update()
        {
            var position = _model.Position;
            _view.X = String.Format("{0:f4}", position.X);
            _view.Y = String.Format("{0:f4}", position.Y);
        }
    }
}