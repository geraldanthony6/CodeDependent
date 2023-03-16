using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.IO;
public class PlayerManager : MonoBehaviour
{
    [SerializeField]private GameObject playerPrefab;
    PhotonView PV;

    GameObject controller;

    private void Awake() {
        PV = GetComponent<PhotonView>();
    }

    // Start is called before the first frame update
    void Start()
    {
        if(PV.IsMine && PhotonNetwork.IsMasterClient)
        {
            CreateController(0);
        } else if(PV.IsMine){
            CreateController(1);
        }
    }

    void CreateController(int spawnIndex){
        Transform spawnpoint = SpawnManager.Instance.GetSpawnPoint(spawnIndex);
        controller = PhotonNetwork.Instantiate(playerPrefab.name, spawnpoint.position, spawnpoint.rotation);
    }
}
