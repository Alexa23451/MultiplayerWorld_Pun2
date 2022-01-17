using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIEvent : MonoBehaviour , ITutorialEvent
{
    private Image bg;

    public void Enter()
    {
        bg.DOColor(Color.black , 1f);
    }

    public void Exit()
    {
        bg.DOColor(Color.white, 1f);
    }

    void Start()
    {
       bg = GetComponent<Image>();
       EventController.Instance.RegisterEvent<UIEvent>(this);
    }

    
}
