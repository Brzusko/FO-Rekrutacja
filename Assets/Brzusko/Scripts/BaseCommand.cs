using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Brzusko.Interfaces;

public class BaseCommand : MonoBehaviour, ICommand
{
    protected CommandSO _commandData;
    public CommandSO CommandData => _commandData;

    public virtual void InjectData<T>(T dataToInject) where T : class
    {
        if (dataToInject.GetType() != typeof(CommandSO))
        {
            Debug.LogError($"Command data should be type of {typeof(CommandSO).FullName}");
            return;
        }

        _commandData = dataToInject as CommandSO;
    }

    public void Spawn()
    {
        
    }
}
