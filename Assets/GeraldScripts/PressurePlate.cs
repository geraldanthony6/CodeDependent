using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    [SerializeField]private GameObject pressurePlateVisual;
    private bool done = false; 
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("Stepped On");
        if(other.CompareTag("Player")){
            pressurePlateVisual.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other) {
        if(!done) {
            if(other.CompareTag("Player")){
                pressurePlateVisual.SetActive(false);
            }
        }
    }

    private void stayLit() {
        done = true;
    }
}
