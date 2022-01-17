using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharOBj : MonoBehaviour
{
    public static CharOBj Instance;

    [SerializeField] private BaseStat health;
    [SerializeField] private BaseStat damage;

    private void Start()
    {
        Instance = this;
    }

    public void ApplyModifier(List<DataStat> dataStats)
    {
        foreach(var data in dataStats)
        {
            health.Modifier(data.typeStat, data.val);
            damage.Modifier(data.typeStat, data.val);
        }

    }
}
