using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeTriggerField : MonoBehaviour
{
    [SerializeField]private GameObject pipe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            pipe.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.CompareTag("Player")){
            pipe.SetActive(false);
        }
    }
}
