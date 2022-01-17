using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using Photon.Realtime;

public class ChangeSceneScript : MonoBehaviourPunCallbacks
{
    public GameObject button;
    void Start()
    {
        button.SetActive(PhotonNetwork.IsMasterClient);
    }
    public void sceneselect()
    {
        SceneManager.LoadScene("Game 1");
    }
    public override void OnMasterClientSwitched(Player newMasterClient)
    {
        button.SetActive(PhotonNetwork.IsMasterClient);
    }
}
