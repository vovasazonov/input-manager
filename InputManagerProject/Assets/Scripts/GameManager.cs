using DpadSample;
using Inputs;
using Scenes.Scripts.TouchSample;
using Scenes.Scripts.TouchSample.Pinch;
using Scenes.Scripts.TouchSample.Swipe;
using TouchSample.Tap;
using UnityEngine;

public sealed class GameManager : MonoBehaviour
{
    [SerializeField] private DpadCoordinatesView _dpadCoordinatesView;
    [SerializeField] private TapView _tapView;
    [SerializeField] private CameraSwipeView cameraSwipeView;
    [SerializeField] private ImagePinchView _imagePinchView;
    private IInputManager _inputManager;
    private IPresenter _dpadPresenter;
    private IPresenter _tapPresenter;
    private IPresenter _cameraSwipePresenter;
    private IPresenter _imagePinchPresenter;

    private void Awake()
    {
        _inputManager = new InputManager();
        _dpadPresenter = new DpadPresenter(_dpadCoordinatesView, new DpadModel(_inputManager.Dpad));
        _tapPresenter = new TapPresenter(_tapView, new TapModel(_inputManager.TouchSystem.TapGesture));
        _cameraSwipePresenter = new CameraSwipePresenter(cameraSwipeView, new CameraSwipeModel(_inputManager.TouchSystem));
        _imagePinchPresenter = new ImagePinchPresenter(_imagePinchView, new ImagePinchModel(_inputManager.TouchSystem));
    }

    private void OnEnable()
    {
        _dpadPresenter.Activate();
        _tapPresenter.Activate();
        _cameraSwipePresenter.Activate();
        _imagePinchPresenter.Activate();
    }
}