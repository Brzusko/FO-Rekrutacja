using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCommand", menuName = "Units/Commands/Command")]
public class CommandSO : ScriptableObject
{
    [SerializeField]
    private string _commandName;
    [SerializeField]
    private float _cooldown;
    [SerializeField]
    private Sprite _icon;
}
