using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class TestGameManager : MonoBehaviourPunCallbacks
{
    public static TestGameManager Instance;
    [SerializeField]private GameObject player1;
    [SerializeField]private GameObject player2;
    [SerializeField]private TextMeshProUGUI _scoreText;
    [SerializeField]private int _score;

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
        
    }

    // Update is called once per frame
    void Update()
    {
        _scoreText.text = "Score: " + _score;
    }

    public void UpdateScore(int addToScore)
    {
        _score += addToScore;
    }

    [PunRPC]    
    public void SetPlayer1(GameObject player){
        player1 = player;
    }
    [PunRPC]
    public void SetPlayer2(GameObject player){
        player2 = player;
    }
}
