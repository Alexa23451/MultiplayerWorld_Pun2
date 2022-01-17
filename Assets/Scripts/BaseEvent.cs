using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface ITutorialEvent
{
    void Enter();
    void Exit();
}

public abstract class BaseEvent : MonoBehaviour
{
    private Dictionary<Type, ITutorialEvent> eventDic = new Dictionary<Type, ITutorialEvent>();

    protected ITutorialEvent currentEvent;

    public void RegisterEvent<T>(T typeClass) where T : class, ITutorialEvent
    {
        if (!eventDic.ContainsKey(typeof(T)))
        {
            ITutorialEvent TTutorial = (ITutorialEvent) typeClass;
            var type = typeof(T);
            eventDic[type] = TTutorial;
            Debug.Log("Register " + type);
        }
    }

    public void StartEvent<T>() where T : ITutorialEvent
    {
        if(currentEvent != null)
        {
            currentEvent.Exit();
        }

        if (eventDic.ContainsKey(typeof(T)))
        {
            currentEvent = eventDic[typeof(T)];
            currentEvent.Enter();
        }
    }


}
