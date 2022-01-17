using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TestTest : MonoBehaviour
{
    public List<DataStat> baseStats = new List<DataStat>();
    
    [ContextMenu("TEST")]
    public void ApplyEffect()
    {
        CharOBj.Instance.ApplyModifier(baseStats);
    }
}
