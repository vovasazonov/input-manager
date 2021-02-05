using Inputs;
using Scenes.Scripts.DpadSample;
using UnityEngine;

public sealed class GameManager : MonoBehaviour
{
    [SerializeField] private DpadCoordinatesView _dpadCoordinatesView;
    private IInputManager _inputManager;
    private DpadPresenter _dpadPresenter;

    private void Awake()
    {
        _inputManager = new InputManager();
        _dpadPresenter = new DpadPresenter(_dpadCoordinatesView, new DpadModel(_inputManager.Dpad));
    }

    private void Update()
    {
        _dpadPresenter.Update();
    }
}