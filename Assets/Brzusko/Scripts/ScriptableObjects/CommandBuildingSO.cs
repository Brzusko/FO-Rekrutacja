using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCommandBuilding", menuName = "Units/Commands/BuildingCommand")]
public class CommandBuildingSO : CommandSO
{
    [SerializeField]
    private BuildingSO[] _buildingsToBuild;
}
