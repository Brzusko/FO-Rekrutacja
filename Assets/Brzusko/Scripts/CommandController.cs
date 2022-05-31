using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Brzusko.Interfaces;

public class CommandController : MonoBehaviour, ICommandController
{
    public int _commandsCount = 0;
    private Dictionary<string, ICommand> _commands = new Dictionary<string, ICommand>();
    public bool Register(ICommand commandToRegister)
    {
        if(commandToRegister == null || _commands.ContainsKey(commandToRegister.CommandData.CommandName))
        {
            Debug.LogError("Command could not be registred");
            return false;
        }

        _commands.Add(commandToRegister.CommandData.CommandName, commandToRegister);
        _commandsCount++;
        return true;
    }
}
