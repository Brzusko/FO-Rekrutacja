using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Brzusko.Interfaces;
public class UnitBuilder : MonoBehaviour, IUnitBuilder
{
    [SerializeField]
    private Transform _commandsContainer;
    private ICommandController _commandController;

    private void Start()
    {
        _commandController = _commandsContainer.GetComponent<ICommandController>();
    }

    public void Build(UnitSO unitData)
    {
        CreateCommands(unitData.Comamnds);
    }

    private void CreateCommands(IList<CommandSO> commands)
    {
        foreach(var command in commands)
        {
            var commandGO = Instantiate(command.CommandObject);
            commandGO.transform.SetParent(_commandsContainer);
            var commandToValidate = commandGO.GetComponent<ICommand>();

            if(commandToValidate == null)
            {
                Destroy(commandGO);
                return;
            }

            commandToValidate.InjectData(command);

            if(!_commandController.Register(commandToValidate))
            {
                Destroy(commandGO);
            }
        }
    }
}
