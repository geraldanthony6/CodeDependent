using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestGameManager : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI _scoreText;
    [SerializeField]private int _score;
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
}
