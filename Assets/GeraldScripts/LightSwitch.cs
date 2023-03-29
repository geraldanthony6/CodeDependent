using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class LightSwitch : MonoBehaviour
{
    [SerializeField]private GameObject light;
    private bool moveLight = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(moveLight){
            MoveLight();
        }
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
}
