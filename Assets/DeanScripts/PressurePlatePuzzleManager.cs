using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class PressurePlatePuzzleManager : MonoBehaviour
{
    public static PressurePlatePuzzleManager instance;
    [SerializeField]private OverallPuzzleManager overallManager;
    [SerializeField]private PressurePlate[] platesInOrder = new PressurePlate[3];
    [SerializeField]private GameObject completionIndicator;
    private int progress = 0;
    private bool done = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkProgress(PressurePlate plate) {
        if(plate == platesInOrder[progress]) {
            platesInOrder[progress].stayLit() ;
            if(progress < platesInOrder.Length - 1) {
                progress++;
                Debug.Log(progress);
            } else {
                done = true;
            }
        } else {
            progress = 0;
            for(int i = 0; i < platesInOrder.Length; i++) {
                platesInOrder[i].failure();
            }
        }
        if(done) {
            overallManager.complete(0);
        }
    }
}
