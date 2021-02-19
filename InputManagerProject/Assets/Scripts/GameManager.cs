using System.Collections.Generic;
using Inputs;
using Samples;
using Samples.UI;
using UnityEngine;

public sealed class GameManager : MonoBehaviour
{
    [SerializeField] private CoordinatesView _coordinatesView;
    [SerializeField] private PointView _pointView;
    [SerializeField] private DialogView _inventoryDialogView;
    [SerializeField] private DialogView _skillSettingDialogView;
    [SerializeField] private List<SkillButtonView> _skillButtonViews;
    [SerializeField] private List<SkillSettingView> _skillSettingViews;
    [SerializeField] private SkillPerformView _skillPerformView;
    
    private IInputManager _inputManager;
    private readonly List<IPresenter> _presenters = new List<IPresenter>();

    private void Awake()
    {
        _inputManager = new InputManager();
        
        var stickModel = new StickModel(_inputManager.PlayerControl.MovementAction);
        var pointModel = new PointModel(_inputManager.PlayerControl);
        var inventoryDialogModel = new DialogModel(_inputManager.PlayerControl.InventoryDialogAction);
        var skillSettingDialogModel = new DialogModel(_inputManager.PlayerControl.SkillSettingDialogAction);
        var fireSkillModel = new SkillModel(_inputManager.PlayerControl.SkillAction1, "fire skill");
        var iceSkillModel = new SkillModel(_inputManager.PlayerControl.SkillAction2, "ice skill");
        
        _presenters.Add(new StickCoordinatesPresenter(_coordinatesView, stickModel));
        _presenters.Add(new PointPresenter(_pointView, pointModel));
        _presenters.Add(new DialogPresenter(_inventoryDialogView, inventoryDialogModel));
        _presenters.Add(new DialogPresenter(_skillSettingDialogView, skillSettingDialogModel));
        _presenters.Add(new SkillButtonPresenter(_skillButtonViews[0], fireSkillModel));
        _presenters.Add(new SkillButtonPresenter(_skillButtonViews[1], iceSkillModel));
        _presenters.Add(new SkillSettingPresenter(_skillSettingViews[0], fireSkillModel));
        _presenters.Add(new SkillSettingPresenter(_skillSettingViews[1], iceSkillModel));
        _presenters.Add(new SkillPerformPresenter(_skillPerformView, fireSkillModel));
        _presenters.Add(new SkillPerformPresenter(_skillPerformView, iceSkillModel));
    }

    private void OnEnable()
    {
        _inputManager.PlayerControl.Activate();
        
        _presenters.ForEach(p=>p.Activate());
    }
}