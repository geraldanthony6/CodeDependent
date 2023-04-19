using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    [SerializeField]private PressurePlatePuzzleManager manager;
    [SerializeField]private GameObject pressurePlateVisual;
    private bool done = false; 
    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update(){}

    // Function -> Called on player collision with pressure plate
    // If pressure plate is NOT activated correctly yet, check if it should be
    private void OnTriggerEnter(Collider other) {
        Debug.Log("Stepped On");
        if(!(pressurePlateVisual.activeSelf)) {
            manager.checkProgress(this);
        }
        if(other.CompareTag("Player")){
            pressurePlateVisual.SetActive(true);
        }
    }

    //Function -> Called when player leaves pressure plate
    // If the pressure plate was correct, it stays activated
    private void OnTriggerExit(Collider other) {
        if(!done) {
            if(other.CompareTag("Player")){
                pressurePlateVisual.SetActive(false);
            }
        }
    }

    // Function -> Sets flag for pressure plate to stay lit
    public void stayLit() {
        done = true;
    }

    // Function -> Resets 'stay lit' flag on screw up
    public void failure() {
        pressurePlateVisual.SetActive(false);
        done = false;
    }
}
