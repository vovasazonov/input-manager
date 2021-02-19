using System.Collections.Generic;
using Inputs;
using Samples;
using Samples.UI;
using UnityEngine;

public sealed class GameManager : MonoBehaviour
{
    [SerializeField] private CoordinatesView _coordinatesView;
    [SerializeField] private PointView _pointView;
    [SerializeField] private DialogView _dialogView;
    [SerializeField] private List<ActionButtonView> _actionButtonViews;
    
    private IInputManager _inputManager;
    private readonly List<IPresenter> _presenters = new List<IPresenter>();

    private void Awake()
    {
        _inputManager = new InputManager();
        
        var stickModel = new StickModel(_inputManager.PlayerControl.MovementAction);
        var pointModel = new PointModel(_inputManager.PlayerControl);
        var inventoryDialogModel = new DialogModel(_inputManager.PlayerControl.InventoryDialogAction);
        var actionButton1Model = new ActionButtonModel(_inputManager.PlayerControl.SkillAction1);
        var actionButton2Model = new ActionButtonModel(_inputManager.PlayerControl.SkillAction2);
        
        _presenters.Add(new StickCoordinatesPresenter(_coordinatesView, stickModel));
        _presenters.Add(new PointPresenter(_pointView, pointModel));
        _presenters.Add(new DialogPresenter(_dialogView, inventoryDialogModel));
        _presenters.Add(new ActionButtonPresenter(_actionButtonViews[0], actionButton1Model));
        _presenters.Add(new ActionButtonPresenter(_actionButtonViews[1], actionButton2Model));
    }

    private void OnEnable()
    {
        _inputManager.PlayerControl.Activate();
        
        _presenters.ForEach(p=>p.Activate());
    }
}