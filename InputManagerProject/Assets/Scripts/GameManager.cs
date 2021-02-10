using Inputs;
using Samples;
using UnityEngine;

public sealed class GameManager : MonoBehaviour
{
    [SerializeField] private CoordinatesView _coordinatesView;
    [SerializeField] private PointView pointView;
    private IInputManager _inputManager;
    private IPresenter _stickCoordinatesPresenter;
    private IPresenter _pointClickPresenter;

    private void Awake()
    {
        _inputManager = new InputManager();
        
        var stickModel = new StickModel(_inputManager.PlayerControl.MovementAction);
        var pointModel = new PointModel(_inputManager.PlayerControl);
        
        _stickCoordinatesPresenter = new StickCoordinatesPresenter(_coordinatesView, stickModel);
        _pointClickPresenter = new PointPresenter(pointView, pointModel);
    }

    private void OnEnable()
    {
        _inputManager.PlayerControl.Activate();
        
        _stickCoordinatesPresenter.Activate();
        _pointClickPresenter.Activate();
    }
}