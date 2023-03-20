using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class TestGameManager : MonoBehaviourPunCallbacks
{
    public static TestGameManager Instance;
    // [SerializeField]private GameObject player1;
    // [SerializeField]private GameObject player2;
    [SerializeField]private TextMeshProUGUI _scoreText;
    [SerializeField]private int _score;
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
