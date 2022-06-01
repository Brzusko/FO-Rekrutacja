using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Brzusko.Enums;
[CreateAssetMenu(fileName = "NewUnit", menuName = "Units/Unit")]
public class UnitSO : ScriptableObject
{
    [SerializeField]
    private Teams _unitTeam = Teams.NONE;
    [SerializeField]
    private string _unitName;
    [SerializeField]
    private float _maxHealth;
    [SerializeField]
    private float _movementSpeed;
    [SerializeField]
    private Sprite _unitIcon;
    //list of commands
    [SerializeField]
    private CommandSO[] _commands;
    public IList<CommandSO> Comamnds => _commands;
}
