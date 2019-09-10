using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    [SerializeField]
    public Image timerBar;
[SerializeField]
    public float timeLeft;
[SerializeField]
    public float timeScale;

    public GameObject player1;

    public GameObject player2;

    public GameObject ball;

    public Text finalText;
    public GameObject finalTextObject;
    private int playerOneScore;

    private int playerTwoScore;
    // Start is called before the first frame update
    void Start()
    {
        timeLeft = 1;
    }

    // Update is called once per frame
    void Update()
    {

        if (timeLeft > -1f)
        {
            timeLeft = timeLeft - timeScale * Time.deltaTime;
            timerBar.fillAmount = timeLeft;
            playerOneScore = GameObject.Find("RespawnTrigger1").GetComponent<respawnScript>().score;
            playerTwoScore = GameObject.Find("RespawnTrigger2").GetComponent<respawnScript>().score;
        }

        if (timeLeft <= 0f)
        {
            //SceneManager.LoadScene("WinLossScreen");
            
            
            player1.SetActive(false);
            player2.SetActive(false);
            ball.SetActive(false);
            finalTextObject.SetActive(true);
            

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
            Debug.Log("End");
        }
    }
}
