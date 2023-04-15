using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField]private Door correctDoor;
    [SerializeField]private Door wrongDoor;
    [SerializeField]private PuzzleLights puzzleLight;
    public Transform pipeEnd;
    public bool isCorrectPipe = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Ball") && isCorrectPipe){
            correctDoor.ChangeOpening();
            other.transform.position = pipeEnd.position;
            AudioManager.Instance.PlayRoomOneCompletedAudio();
            puzzleLight.indicateCompletion();
        } else if(other.CompareTag("Ball") && !isCorrectPipe){
            wrongDoor.ChangeOpening();
            other.transform.position = pipeEnd.position;
        }
    }
}
