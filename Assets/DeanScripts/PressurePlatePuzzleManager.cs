using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class PressurePlatePuzzleManager : MonoBehaviour
{
    public static PressurePlatePuzzleManager instance;

    [SerializeField]private GameObject[] playerOneGameObjects = new GameObject[3];
    private int progress = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkProgress(GameObject plate) {
        if(plate) {
            
        }
    }
}
