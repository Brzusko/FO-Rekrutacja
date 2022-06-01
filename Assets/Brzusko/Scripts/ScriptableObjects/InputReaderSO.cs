using System;
using UnityEngine;
using UnityEngine.InputSystem;
using Brzusko.Events;

[CreateAssetMenu(fileName = "NewInputReader", menuName = "Inputs/InputReader")]
public class InputReaderSO : ScriptableObject, RTSGameplay.IGameplayActions
{
    public event EventHandler<InteractionEventArgs> Interaction;
    private RTSGameplay _input;
    private bool _isAdditionClicked;
    private void OnEnable()
    {
        if(_input == null)
        {
            _input = new RTSGameplay();
            _input.Gameplay.SetCallbacks(this);
        }

        _input.Gameplay.Enable();
    }

    private void OnDisable()
    {
        _input.Gameplay.Disable();
    }

    public void OnInteraction(InputAction.CallbackContext ctx)
    {
        Interaction?.Invoke(null, new InteractionEventArgs { IsAdditionClicked = _isAdditionClicked });
    }

    public void OnAddition(InputAction.CallbackContext ctx)
    {
        _isAdditionClicked = ctx.phase == InputActionPhase.Performed;
    }
}
