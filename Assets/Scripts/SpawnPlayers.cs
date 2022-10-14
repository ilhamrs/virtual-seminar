using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;
    public float x;
    public float z;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 randomPos = new Vector3(Random.Range(-x, x), 0, Random.Range(-z, z));

        PhotonNetwork.Instantiate(playerPrefab.name, randomPos, Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
