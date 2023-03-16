using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField]private int playerNum = 0;
    [SerializeField]private GameObject friend;
    [SerializeField]PhotonView view;

    private void Awake() {
        if(PhotonNetwork.IsMasterClient){
            playerNum = 0;
            TestGameManager.Instance.SetPlayer1(gameObject);
        } else {
            playerNum = 1;
            TestGameManager.Instance.SetPlayer2(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    [PunRPC]
    public void SetPlayerNum(int playerNum){
        this.playerNum = playerNum;
    }
    [PunRPC]
    public void SetOtherPlayer(GameObject otherPlayer){
        friend = otherPlayer;
    }
}
