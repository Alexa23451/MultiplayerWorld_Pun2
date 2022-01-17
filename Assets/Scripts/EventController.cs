using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController : BaseEvent
{
    public static EventController Instance;

    private void OnEnable()
    {
        Instance = this;
    }

    private void Start()
    {
        //define tutorial event here

        //StartEvent<UIEvent>();
        //StartEvent<GamePlayEvent>();

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartEvent<GamePlayEvent>();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            StartEvent<UIEvent>();
        }
    }



}
