using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemScript : MonoBehaviour
{
    public Renderer rend;
    public int flag;
    public PlayerNumber Player;
    private int playerNum;

    void Start()
    {
        rend = GetComponent<Renderer>();
        playerNum = Player.playerNum;

        if(playerNum == flag || flag == 3) {
            rend.enabled = true;
        } else {
            rend.enabled = false;
        }
    }

    void Update()
    {
        
    }
}
