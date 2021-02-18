using Inputs;
using Samples;
using Samples.UI;
using UnityEngine;

public sealed class GameManager : MonoBehaviour
{
    [SerializeField] private CoordinatesView _coordinatesView;
    [SerializeField] private PointView _pointView;
    [SerializeField] private DialogView _dialogView;
    
    private IInputManager _inputManager;
    private IPresenter _stickCoordinatesPresenter;
    private IPresenter _pointClickPresenter;
    private IPresenter _inventoryDialogPresenter;

    private void Awake()
    {
        _inputManager = new InputManager();
        
        var stickModel = new StickModel(_inputManager.PlayerControl.MovementAction);
        var pointModel = new PointModel(_inputManager.PlayerControl);
        var inventoryDialogModel = new DialogModel(_inputManager.PlayerControl.InventoryDialogAction);
        
        _stickCoordinatesPresenter = new StickCoordinatesPresenter(_coordinatesView, stickModel);
        _pointClickPresenter = new PointPresenter(_pointView, pointModel);
        _inventoryDialogPresenter = new DialogPresenter(_dialogView, inventoryDialogModel);
    }

    private void OnEnable()
    {
        _inputManager.PlayerControl.Activate();
        
        _stickCoordinatesPresenter.Activate();
        _pointClickPresenter.Activate();
        _inventoryDialogPresenter.Activate();
    }
}