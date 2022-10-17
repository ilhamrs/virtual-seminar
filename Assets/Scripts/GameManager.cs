using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class GameManager : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Escape))
        //{
        //    OnLeftRoom();
        //}
    }

    //public override void OnLeftRoom()
    //{
    //    PhotonNetwork.LoadLevel("MainMenu");
    //    PhotonNetwork.LeaveRoom();
    //}
}
