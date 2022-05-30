using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Brzusko.Interfaces;

public class Unit : MonoBehaviour, ISpawnable
{
    [SerializeField]
    private UnitSO _unitData;
    private IUnitBuilder _builder;

    protected virtual void Awake()
    {
        _builder = GetComponent<IUnitBuilder>();
    }

    protected virtual void Start()
    {
        Spawn();
    }

    public void InjectData<T>(T dataToInject) where T : class
    {
        if(dataToInject.GetType() != typeof(UnitSO))
        {
            Debug.LogError("Injected Data is not correct Type!");
            return;
        }

        _unitData = dataToInject as UnitSO;
    }

    public void Spawn()
    {
        _builder.Build(_unitData);
    }
}
