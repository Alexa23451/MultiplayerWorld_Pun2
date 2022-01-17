using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityStandardAssets.Characters.ThirdPerson;

public class DisableUnneededScriptsForOtherPlayers : MonoBehaviourPun
{
    void Start()
    {
        PhotonView PV = GetComponent<PhotonView>();
        ThirdPersonUserControl usercont = GetComponent<ThirdPersonUserControl>();
        ThirdPersonCharacter character = GetComponent<ThirdPersonCharacter>();
        Transform canvas = transform.Find("Canvas");
        if (PV.IsMine)
        {
            gameObject.tag = "Player";
        }
        else
        {
            Destroy(canvas.gameObject);
            Destroy(usercont);
            Destroy(character);
            Destroy(this);
        }
    }
}
