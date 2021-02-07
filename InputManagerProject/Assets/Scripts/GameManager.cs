using Inputs;
using Scenes.Scripts.DpadSample;
using Scenes.Scripts.TouchSample;
using Scenes.Scripts.TouchSample.Swipe;
using UnityEngine;

public sealed class GameManager : MonoBehaviour
{
    [SerializeField] private DpadCoordinatesView _dpadCoordinatesView;
    [SerializeField] private TapView _tapView;
    [SerializeField] private CameraView cameraView;
    private IInputManager _inputManager;
    private DpadPresenter _dpadPresenter;
    private TapPresenter _tapPresenter;
    private CameraPresenter _cameraPresenter;

    private void Awake()
    {
        _inputManager = new InputManager();
        _dpadPresenter = new DpadPresenter(_dpadCoordinatesView, new DpadModel(_inputManager.Dpad));
        _tapPresenter = new TapPresenter(_tapView, new TapModel(_inputManager.TouchSystem.TapGesture));
        _cameraPresenter = new CameraPresenter(cameraView, new CameraModel(_inputManager.TouchSystem));
    }

    private void OnEnable()
    {
        _dpadPresenter.Activate();
        _tapPresenter.Activate();
        _cameraPresenter.Activate();
    }
}