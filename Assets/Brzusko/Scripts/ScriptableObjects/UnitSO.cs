using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewUnit", menuName = "Units/Unit")]
public class UnitSO : ScriptableObject
{
    [SerializeField]
    private float _maxHealth;
    [SerializeField]
    private float _movementSpeed;
    [SerializeField]
    private Sprite _unitIcon;

    //list of commands
}
