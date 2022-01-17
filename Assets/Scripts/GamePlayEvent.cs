using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GamePlayEvent : MonoBehaviour , ITutorialEvent
{

    void Start()
    {
        EventController.Instance.RegisterEvent<GamePlayEvent>(this);
    }

    public void Enter()
    {
        transform.DOScale(Vector3.one * 2, 1f);
    }

    public void Exit()
    {
        transform.DOScale(Vector3.one, 1f);
    }
}
