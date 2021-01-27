using Inputs;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private IInputManager _inputManager;

    private void Awake()
    {
        _inputManager = new InputManager();
    }

    private void Update()
    {
        Debug.Log($"X: {_inputManager.Dpad.Position.X} Y: {_inputManager.Dpad.Position.Y}");
    }
}