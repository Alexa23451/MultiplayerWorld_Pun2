using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class InstatiatePlayer : MonoBehaviour
{
    [SerializeField] private GameObject PLayerPrefab = null;
    public Vector3 Player_Spawn_Position;
    public bool Use_Custom_Spawn_Position = false;
    void Start()
    {
        if (Use_Custom_Spawn_Position)
        {
            PhotonNetwork.Instantiate(PLayerPrefab.name, Player_Spawn_Position, Quaternion.identity);
        }
        else
            PhotonNetwork.Instantiate(PLayerPrefab.name, new Vector3(Random.Range(-10.0f, 10.0f), 2f, 0), Quaternion.identity);
    }
}
