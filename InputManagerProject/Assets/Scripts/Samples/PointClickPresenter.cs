using Inputs;

namespace Samples
{
    public sealed class PointClickPresenter : IPresenter
    {
        private readonly IPointClickView _view;
        private readonly IClickAction _model;

        public PointClickPresenter(IPointClickView view, IClickAction model)
        {
            _view = view;
            _model = model;
        }
        
        public void Activate()
        {
            _model.Clicked += OnClicked;
        }

        public void Deactivate()
        {
            _model.Clicked -= OnClicked;
        }

        private void OnClicked(IVector2 screenPosition, int amount)
        {
            _view.SetPosition(screenPosition);
        }
    }
}