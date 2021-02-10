using Inputs;
using Samples;
using UnityEngine;
using UnityEngine.Serialization;

public sealed class GameManager : MonoBehaviour
{
    [SerializeField] private CoordinatesView _coordinatesView;
    [SerializeField] private PointClickView _pointClickView;
    private IInputManager _inputManager;
    private IPresenter _stickCoordinatesPresenter;
    private IPresenter _pointClickPresenter;

    private void Awake()
    {
        _inputManager = new InputManager();
        
        var stickModel = new StickModel(_inputManager.PlayerControl.MovementAction);
        
        _stickCoordinatesPresenter = new StickCoordinatesPresenter(_coordinatesView, stickModel);
        _pointClickPresenter = new PointClickPresenter(_pointClickView, _inputManager.PlayerControl.ClickAction);
    }

    private void OnEnable()
    {
        _inputManager.PlayerControl.Activate();
        
        _stickCoordinatesPresenter.Activate();
        _pointClickPresenter.Activate();
    }
}