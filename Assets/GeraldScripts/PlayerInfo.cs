using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerInfo : MonoBehaviour
{

    private PhotonView view;
   

    private void Awake() {
        view = GetComponent<PhotonView>();
    }
    // Start is called before the first frame update
    void Start()
    {
        if(view.IsMine && PhotonNetwork.IsMasterClient){
            foreach (GameObject gameObject in TestGameManager.Instance.GetPlayerOneObjects())
            {
                gameObject.SetActive(true);
            }
        } else if(view.IsMine && !PhotonNetwork.IsMasterClient){
            foreach (GameObject gameObject in TestGameManager.Instance.GetPlayerTwoObjects())
            {
                gameObject.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
