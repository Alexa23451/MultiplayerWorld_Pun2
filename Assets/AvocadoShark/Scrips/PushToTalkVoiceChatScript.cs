using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Voice.Unity;
using Photon.Voice.PUN;
using UnityEngine.UI;

public class PushToTalkVoiceChatScript : MonoBehaviourPun
{
    public KeyCode PushButton = KeyCode.P;
    public Recorder VoiceRecorder;
    public Text textpushtotalk;
    private PhotonView view;
    private bool pushtotalk = true;
    void Start()
    {
        view = photonView;
        VoiceRecorder.TransmitEnabled = false;
    }
    void Update()
    {
        if (pushtotalk)
        {
            if (Input.GetKeyDown(PushButton))
            {
                if (view.IsMine)
                {
                    VoiceRecorder.TransmitEnabled = true;
                }
            }
            else if (Input.GetKeyUp(PushButton))
            {
                if (view.IsMine)
                {
                    VoiceRecorder.TransmitEnabled = false;
                }
            }
        }
        else
            VoiceRecorder.TransmitEnabled = true;
    }
    public void changepushtotalk(bool change)
    {
        pushtotalk = change;
        if (change)
        {
            textpushtotalk.text = "Push To Talk";
            VoiceRecorder.TransmitEnabled = false;
        }
        else
            textpushtotalk.text = "Mic Always On";
    }
}
