using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum TypeStat
{
    Health, Damage,
}

[System.Serializable]
public struct DataStat
{
    public TypeStat typeStat;
    public int val;
}

public class BaseStatTemplate<T> where T : Enum
{
    public int baseValue;
    [SerializeField] protected T typeStat;

    public void Modifier(T x, int val)
    {
        if(x.Equals(typeStat))
        {
            baseValue += val;
            Debug.Log(x.ToString() + " ADD");
        }
    }
}

[System.Serializable]
public class BaseStat : BaseStatTemplate<TypeStat>
{

}

