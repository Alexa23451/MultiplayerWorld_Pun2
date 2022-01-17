using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class EnterAndSaveNameScript : MonoBehaviour
{
    public InputField nameInpunField;
    void Start()
    {
        if (!PlayerPrefs.HasKey("PlayerName"))
        {
            return;
        }
        else
        {
            string PlayerName = PlayerPrefs.GetString("PlayerName");
            nameInpunField.text = PlayerName;
        }
    }
    public void PlacePlayerName()
    {
        string PlayerNickname = nameInpunField.text;
        PhotonNetwork.NickName = PlayerNickname;
        PlayerPrefs.SetString("PlayerName", PlayerNickname);
    }
}
