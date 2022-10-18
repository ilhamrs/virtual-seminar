using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using TMPro;
using UnityEngine;

public class UsernameDisplay : MonoBehaviour
{
    [SerializeField] PhotonView playerPV;
    [SerializeField] TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = playerPV.Owner.NickName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
