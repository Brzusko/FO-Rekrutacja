using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Brzusko.Interfaces;
using Brzusko.Events;

public class UnitSelector : MonoBehaviour, IInputConsumer, IUnitSelector
{
    [SerializeField]
    private InputReaderSO _inputReader;

    [SerializeField]
    private Camera _camera;

    private bool _callbacksConsumed = false;
    private Dictionary<bool, Action<ISelectable>> _interactionMap = new Dictionary<bool, Action<ISelectable>>();

    private void Start()
    {
        _interactionMap[false] = new Action<ISelectable>(SelectOne);
        _interactionMap[true] = new Action<ISelectable>(SelectMany);
        RegisterInputCallbacks(_inputReader);
    }

    private void OnDestroy()
    {
        UnregisterInputCallbacks(_inputReader);
    }

    public void RegisterInputCallbacks(InputReaderSO inputReader)
    {
        if (_callbacksConsumed)
            return;

        _callbacksConsumed = true;
        _inputReader.Interaction += OnInteraction;
    }

    public void SelectMany(ISelectable selectable)
    {
        throw new System.NotImplementedException();
    }

    public void SelectOne(ISelectable selectable)
    {
        throw new System.NotImplementedException();
    }

    public void UnregisterInputCallbacks(InputReaderSO inputReader)
    {

    }

    private ISelectable ShootSelectionRay()
    {
        var raycastHit = Physics2D.Raycast(_camera.ScreenToWorldPoint(Mouse.current.position.ReadValue()), Vector2.zero, Mathf.Infinity);
        return null;
    }

    private void OnInteraction(object sender, InteractionEventArgs args)
    {
        //_interactionMap[args.IsAdditionClicked].Invoke();
    }
}
