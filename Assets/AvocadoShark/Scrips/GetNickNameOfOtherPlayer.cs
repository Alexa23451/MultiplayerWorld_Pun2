using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class GetNickNameOfOtherPlayer : MonoBehaviourPun
{
    public Text nametext;
    void Start()
    {
        if (!photonView.IsMine)
        {
            nametext.text = photonView.Owner.NickName;
        }
    }
}
