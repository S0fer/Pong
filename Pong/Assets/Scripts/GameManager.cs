using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;
    
    [Header("Player 1")]
    public GameObject paddle1;
    public GameObject goal1;
    
    [Header("Player 2")]
    public GameObject paddle2;
    public GameObject goal2;
    
    [Header("Score UI")]
    public GameObject Player1Text;
    public GameObject Player2Text;
    
    private int Player1Score;
    private int Player2Score;

    public void Player1Scored()
    {
        Player1Score++;
        Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        ResetPosition();
    }
    public void Player2Scored()
    {
        Player2Score++;
        Player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        ResetPosition();
    }

    public void ResetPosition(){
        ball.GetComponent<Ball>().Reset();
        paddle1.GetComponent<Paddle>().Reset();
        paddle2.GetComponent<Paddle>().Reset();
    }
}
