using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewBuilding", menuName = "Units/Building")]
public class BuildingSO : ScriptableObject
{
    [SerializeField]
    private string _buildingName;
    [SerializeField]
    private GameObject _building;
    [SerializeField]
    private float _timeToBuild;
}
