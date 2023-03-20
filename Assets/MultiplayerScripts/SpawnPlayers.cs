using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    [SerializeField]private GameObject _playerPrefab;
    [SerializeField]private GameObject player1;
    [SerializeField]private GameObject player2;

    [SerializeField]private float _minX;
    [SerializeField]private float _maxX;
    [SerializeField]private float _minZ;
    [SerializeField]private float _maxZ;
    public static int curPlayerNum = 0;

    PhotonView view;

    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();

        Vector3 randomPosition = new Vector3(Random.Range(_minX, _maxX), 1, Random.Range(_minZ, _maxZ));
        PhotonNetwork.Instantiate(_playerPrefab.name, randomPosition, Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [PunRPC]
    void UpdatePlayerNum(){
        curPlayerNum++;
    }

    [PunRPC]    
    public void SetPlayer1(GameObject player){
        player1 = player;
    }
    [PunRPC]
    public void SetPlayer2(GameObject player){
        player2 = player;
    }
}
