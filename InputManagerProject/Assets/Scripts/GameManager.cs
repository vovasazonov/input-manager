using DpadSample;
using Inputs;
using UnityEngine;

public sealed class GameManager : MonoBehaviour
{
    [SerializeField] private StickCoordinatesView _stickCoordinatesView;
    private IInputManager _inputManager;
    private IPresenter _stickCoordinatesPresenter;

    private void Awake()
    {
        _inputManager = new InputManager();
        
        var stickModel = new StickModel(_inputManager.PlayerControls.Movement);
        
        _stickCoordinatesPresenter = new StickCoordinatesPresenter(_stickCoordinatesView, stickModel);
    }

    private void OnEnable()
    {
        _inputManager.PlayerControls.Activate();
        
        _stickCoordinatesPresenter.Activate();
    }
}