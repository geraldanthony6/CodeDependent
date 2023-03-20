using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]private Transform openPosition;
    [SerializeField]private Transform closePosition;
    public bool opening = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(opening){
           Open(); 
        } else if(!opening){
            Close();
        }
    }

    public void Open(){
        transform.position = Vector3.MoveTowards(transform.position, openPosition.position, 3 * Time.deltaTime);
    }

    public void Close(){
        transform.position = Vector3.MoveTowards(transform.position, closePosition.position, 3 * Time.deltaTime);
    }
}
