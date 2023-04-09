using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class TestGameManager : MonoBehaviourPunCallbacks
{
    public static TestGameManager Instance;
    [SerializeField]private TextMeshProUGUI _scoreText;
    [SerializeField]private int _score;
    [SerializeField]private GameObject playerOne;
    [SerializeField]private GameObject playerTwo;
    [SerializeField]private List<GameObject> playerOneGameObjects;
    [SerializeField]private List<GameObject> playerTwoGameObjects;

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
    [PunRPC]
    public void SetPlayerOne(GameObject player){
        playerOne = player;
    }

    public GameObject GetPlayerOne(){
        return playerOne;
    }
    [PunRPC]
    public void SetPlayerTwo(GameObject player){
        playerTwo = player;
    }

    public GameObject GetPlayerTwo(){
        return playerTwo;
    }

    public void UpdateScore(int addToScore)
    {
        _score += addToScore;
    }

    public List<GameObject> GetPlayerOneObjects(){
        return playerOneGameObjects;
    }

    public List<GameObject> GetPlayerTwoObjects(){
        return playerTwoGameObjects;
    }
}
