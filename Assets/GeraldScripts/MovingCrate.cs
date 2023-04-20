using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCrate : MonoBehaviour
{
    [SerializeField]private Transform[] waypoints;
    [SerializeField]private float speed = 1f;
    private int waypointIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = waypoints[waypointIndex].transform.position;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() {
        Move();
    }

    private void Move(){
        if(waypointIndex <= waypoints.Length - 1){
            transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, speed * Time.deltaTime);
            if(transform.position == waypoints[waypointIndex].transform.position){
                waypointIndex += 1;
            }
        } else {
            waypointIndex = 0;
        }
    }
}
