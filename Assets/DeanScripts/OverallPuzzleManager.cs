using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class OverallPuzzleManager : MonoBehaviour
{
    public static OverallPuzzleManager instance;

    [SerializeField]private PuzzleLights[] lights = new PuzzleLights[3];
    [SerializeField]private Material[] completeMat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void complete(int i) {
        lights[i].indicateCompletion();
    }
}
