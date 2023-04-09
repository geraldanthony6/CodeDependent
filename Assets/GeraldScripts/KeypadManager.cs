using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeypadManager : MonoBehaviour
{
    [SerializeField]private string correctCode = "523";
    [SerializeField]private string currentCode = "";
    [SerializeField]private int currentCodeIndex = 0;
    [SerializeField]private TextMeshProUGUI redText;
    [SerializeField]private TextMeshProUGUI yellowText;
    [SerializeField]private TextMeshProUGUI greenText;
    [SerializeField]private GameObject output;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnKeyPressed(string key){
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

    public void OnEnterPressed(){
        Debug.Log("Enter Pressed");
        if(currentCode == correctCode){
            output.gameObject.GetComponent<Image>().color = Color.green;
            AudioManager.Instance.PlayRoomTwoCompletedAudio();
        } else {
            output.gameObject.GetComponent<Image>().color = Color.red;
            currentCode = "";
            currentCodeIndex = 0;
            redText.text = "";
            yellowText.text = "";
            greenText.text = "";
        }
    }
}
