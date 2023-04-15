using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;

public class KeypadManager : MonoBehaviour
{
    [SerializeField]private string correctCode = "523";
    [SerializeField]private string currentCode = "";
    [SerializeField]private int currentCodeIndex = 0;
    [SerializeField]private TextMeshProUGUI redText;
    [SerializeField]private TextMeshProUGUI yellowText;
    [SerializeField]private TextMeshProUGUI greenText;
    [SerializeField]private GameObject output;
    [SerializeField]private OverallPuzzleManager puzzleManager;
    PhotonView _view;
    
    

    // Start is called before the first frame update
    void Start()
    {
        _view = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [PunRPC]
    private void OnKeyPressed(string key){
        Debug.Log("Key Pressed: " + key);
        if(currentCodeIndex == 3){
            currentCodeIndex = 0;
            currentCode = "";
            redText.text = "";
            yellowText.text = "";
            greenText.text = "";
        }
        currentCode += key;
        currentCodeIndex++;
        if(currentCodeIndex == 1){
            redText.text = key;
        } else if(currentCodeIndex == 2){
            yellowText.text = key;
        } else if(currentCodeIndex == 3){
            greenText.text = key;
        }
    }

    [PunRPC]
    private void OnEnterPressed(){
        Debug.Log("Enter Pressed");
        if(currentCode == correctCode){
            output.gameObject.GetComponent<Image>().color = Color.green;
            AudioManager.Instance.PlayRoomTwoCompletedAudio();
            puzzleManager.CompletePlayerTwoPuzzle(0);
        } else {
            output.gameObject.GetComponent<Image>().color = Color.red;
            currentCode = "";
            currentCodeIndex = 0;
            redText.text = "";
            yellowText.text = "";
            greenText.text = "";
        }
    }

    public void CallOnKeyPressed(string key){
        _view.RPC("OnKeyPressed", RpcTarget.All, key);
    }

    public void CallOnEnterPressed(){
        _view.RPC("OnEnterPressed", RpcTarget.All);
    }
}
