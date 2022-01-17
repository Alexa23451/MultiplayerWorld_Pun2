using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class MenuConnectingScript : MonoBehaviourPunCallbacks
{
    private bool isConnecting = false;
    private const string GameVersion = "0.4";
    private const int MaxPlayersPerRoom = 20;
    public GameObject fade;
    private void Awake()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.SendRate = 15;
        PhotonNetwork.SerializationRate = 15;
    }
    public void SearchForGame()
    {
        fade.SetActive(true);
        isConnecting = true;
        if (PhotonNetwork.IsConnected)
        {
            PhotonNetwork.JoinRandomRoom();
        }
        else
        {
            PhotonNetwork.PhotonServerSettings.AppSettings.AppVersion = "0.4";
            PhotonNetwork.GameVersion = "0.1";
            PhotonNetwork.ConnectUsingSettings();
            PhotonNetwork.GameVersion = GameVersion;
        }
    }
    public override void OnConnectedToMaster()
    {
        Debug.Log("Has been connected");
        if (isConnecting)
        {
            PhotonNetwork.JoinRandomRoom();
        }
    }
    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log($"Disconected due to: {cause}");
    }
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("No clients have made any rooms");
        PhotonNetwork.CreateRoom(null, new RoomOptions { MaxPlayers = MaxPlayersPerRoom });
    }
    public override void OnJoinedRoom()
    {
        Debug.Log("Client succesfully joined room");
        PhotonNetwork.LoadLevel("Game");
    }
}
