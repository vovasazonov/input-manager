using DpadSample;
using Inputs;
using UnityEngine;

public sealed class GameManager : MonoBehaviour
{
    [SerializeField] private DpadCoordinatesView _dpadCoordinatesView;
    private IInputManager _inputManager;
    private IPresenter _dpadPresenter;

    private void Awake()
    {
        _inputManager = new InputManager();
        
        var dpadModel = new DpadModel(_inputManager.PlayerControls.Movement);
        
        _dpadPresenter = new DpadPresenter(_dpadCoordinatesView, dpadModel);
    }

    private void OnEnable()
    {
        _inputManager.PlayerControls.Activate();
        
        _dpadPresenter.Activate();
    }
}