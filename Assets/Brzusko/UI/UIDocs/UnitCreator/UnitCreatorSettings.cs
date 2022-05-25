using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UnitCreatorSettings", menuName = "UnitCreator/Settings")]
public class UnitCreatorSettings : ScriptableObject
{
    [SerializeField]
    private GameObject _defaultUnitPrefab;

    [SerializeField]
    private string _unitsCatalogPath;

    public GameObject DefaultUnitPrefab => _defaultUnitPrefab;
    public string UnitCatalogPath => _unitsCatalogPath;
}
