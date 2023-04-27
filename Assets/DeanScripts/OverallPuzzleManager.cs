using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

//Being edited by Gerald

public class OverallPuzzleManager : MonoBehaviour
{
    public static OverallPuzzleManager instance;

    [SerializeField]private PuzzleLights[] player1Lights = new PuzzleLights[3];
    [SerializeField]private PuzzleLights[] player2Lights = new PuzzleLights[3];
    [SerializeField]private Material[] completeMat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CompletePlayerOnePuzzle(int i) {
        player1Lights[i].indicateCompletion();
    }

    public void CompletePlayerTwoPuzzle(int i) {
        player2Lights[i].indicateCompletion();
    }
    
    public void CompletePlayerThreePuzzle(int i) {
        player1Lights[i].indicateCompletion();
        player2Lights[i].indicateCompletion();
    }

    public void complete(int i) {

    }
}
