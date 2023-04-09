using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    [SerializeField]private AudioSource _roomOneAudioSource;
    [SerializeField]private AudioClip _roomOneCompletedAudioClip;
    [SerializeField]private AudioClip _roomTwoCompletedAudioClip;

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
        _roomOneAudioSource.clip = _roomOneCompletedAudioClip;
        _roomOneAudioSource.Play();
    }

    public void PlayRoomTwoCompletedAudio(){
        _roomOneAudioSource.clip = _roomTwoCompletedAudioClip;
        _roomOneAudioSource.Play();
    }
}
