using Inputs;
using UnityEngine;

public sealed class GameManager : MonoBehaviour
{
    [SerializeField] private UnityDpad _dpad;

    private IInputManager _inputManager;

    private void Awake()
    {
        _inputManager = new InputManager(_dpad);
    }

    private void Update()
    {
        Debug.Log($"X: {_inputManager.Dpad.Position.X} Y: {_inputManager.Dpad.Position.Y}");
    }
}