using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    [SerializeField]private AudioSource _initialAudioSource;
    [SerializeField]private AudioSource _puzzleOneCompletedAudioSource;
    [SerializeField]private AudioSource _puzzleTwoCompletedAudioSource;

    private void Awake() {
        if(!Instance){
            Instance = this;
        } else {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        PlayRoomOneAudioSource();
    }

    public void PlayRoomOneAudioSource(){
            _initialAudioSource.Play();   
    }

    public void PlayRoomOneCompletedAudio(){
        _puzzleOneCompletedAudioSource.Play();
    }

    public void PlayRoomTwoCompletedAudio(){
        _puzzleTwoCompletedAudioSource.Play();
    }
}
