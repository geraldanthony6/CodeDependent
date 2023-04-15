using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Photon.Pun;

public class LightSwitch : MonoBehaviour
{
    [SerializeField]private GameObject light;
    [SerializeField]private Material greenMaterial;
    [SerializeField]private bool isComplete = false;
    [SerializeField]private Button button;
    private bool moveLight = false;
    private PhotonView _view;
    
    // Start is called before the first frame update
    void Start()
    {
        _view = GetComponent<PhotonView>();
        button.onClick.AddListener(CallTurnOnLight);
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("Triggered");
        if (other.CompareTag("Player")) {
            moveLight = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        light.GetComponent<Light>().color = Color.blue;
    }

    [PunRPC]
    void ChangeColor() {
        light.GetComponent<Light>().color = Color.green;
    }

    void MoveLight(){
        light.transform.position = Vector3.MoveTowards(light.transform.position, new Vector3(0, 0, 0), 10f * Time.deltaTime);
    }

    [PunRPC]
    public void TurnOnLight(){
        //if(!_view.IsMine) return;
        light.GetComponent<MeshRenderer>().material = greenMaterial;
        isComplete = true;
    }

    private void CallTurnOnLight(){
        Debug.Log("Button Pressed");
        _view.RPC("TurnOnLight", RpcTarget.All);
    }
}
