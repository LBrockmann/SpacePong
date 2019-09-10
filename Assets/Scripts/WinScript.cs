using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScript : MonoBehaviour
{

    public Text finalText;
    public int playerOneScore;
    public int playerTwoScore;// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("RespawnTrigger1").GetComponent<respawnScript>().score = playerOneScore;
        GameObject.Find("RespawnTrigger2").GetComponent<respawnScript>().score = playerTwoScore;

        if (playerOneScore > playerTwoScore)
        {
            finalText.text = ("Player 1 is better at space!");
        }

        if (playerTwoScore > playerOneScore)
        {
            finalText.text = ("Player 2 is better at space!");
        }
        else if (playerOneScore == playerTwoScore)
        {
            finalText.text = ("It's a tie. You are now space brethren for life. Unite this bond with a blood pact.");
        }
    }
}
