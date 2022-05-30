using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Brzusko.Interfaces;
public class UnitBuilder : MonoBehaviour, IUnitBuilder
{
    [SerializeField]
    private Transform _commandsContainer;

    public void Build(UnitSO unitData)
    {
        throw new System.NotImplementedException();
    }
}
