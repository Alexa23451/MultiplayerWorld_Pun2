using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawningAndDestroyingObjectsM : MonoBehaviourPun
{
    public KeyCode Pushbutton = KeyCode.L;
    private PhotonView view;
    private GameObject lightinscene;
    void Start()
    {
        view = photonView;
    }
    void Update()
    {
        if (Input.GetKeyDown(Pushbutton))
        {
            if (view.IsMine)
            {
                PhotonNetwork.Instantiate("Point Light", new Vector3(0, 0, 0), Quaternion.identity, 0);
            }
        }else if (Input.GetKeyUp(Pushbutton))
        {
            if  (view.IsMine)
            {
                lightinscene = GameObject.FindGameObjectWithTag("light");
                PhotonNetwork.Destroy(lightinscene);
            }
        }
    }
}
