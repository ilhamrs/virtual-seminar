using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CameraManager : MonoBehaviour
{
    PhotonView view;
    //Camera cam;
    // Start is called before the first frame update

    private void Awake()
    {
        view = GetComponent<PhotonView>();
    }

    void Start()
    {
        if (!view.IsMine)
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
