using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class TestCube : MonoBehaviour
{
    [SerializeField]private Material greenMaterial;
    [SerializeField]private GameObject otherCube;
    [SerializeField]private Transform newPos;
    [SerializeField]private GameObject light;
    public bool moveToNewPos = false;
    
    PhotonView _view;
    // Start is called before the first frame update
    void Start()
    {
        _view = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if(moveToNewPos){
            transform.position = Vector3.MoveTowards(transform.position, newPos.position, 10f * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other) {
        light.GetComponent<MeshRenderer>().material = greenMaterial;
    }


}
