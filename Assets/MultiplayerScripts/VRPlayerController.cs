using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class VRPlayerController : MonoBehaviour
{
    public PhotonView view;
    public GameObject xrOrigin;
    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();
        
        if(view.IsMine){
            xrOrigin.SetActive(true);
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
