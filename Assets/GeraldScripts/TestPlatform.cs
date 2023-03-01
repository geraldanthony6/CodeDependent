using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlatform : MonoBehaviour
{
    public bool setActive = false;
    [SerializeField]private Transform newPos; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(setActive){
            transform.position = Vector3.MoveTowards(transform.position, newPos.position, 10f * Time.deltaTime);
        }
    }
}
