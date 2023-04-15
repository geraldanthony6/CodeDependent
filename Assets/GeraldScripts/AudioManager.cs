using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    [SerializeField]private AudioSource _roomOneAudioSource;
    [SerializeField]private AudioSource _roomOneCompletedAudioSource;
    [SerializeField]private AudioSource _roomTwoCompletedAudioSource;

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
            _roomOneAudioSource.Play();   
    }

    public void PlayRoomOneCompletedAudio(){
        _roomOneCompletedAudioSource.Play();
    }

    public void PlayRoomTwoCompletedAudio(){
        _roomTwoCompletedAudioSource.Play();
    }
}
