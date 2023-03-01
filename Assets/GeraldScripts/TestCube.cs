using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class TestCube : MonoBehaviour
{
    [SerializeField]private TestGameManager gameManager;
    [SerializeField]private Material redMaterial;
    [SerializeField]private GameObject otherCube;
    [SerializeField]private Transform newPos;
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

    

    // private void OnCollisionEnter(Collision other) {
        
    //         if(other.gameObject.CompareTag("Player")){
    //             gameManager.UpdateScore(1);
    //             // Destroy(gameObject);
    //         }
        
    // }

    private void OnTriggerEnter(Collider other) {
        gameObject.GetComponent<MeshRenderer>().material = redMaterial;
        otherCube.gameObject.GetComponent<TestCube>().moveToNewPos = true;
    }


}
