using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int playerScore;
    public int computerScore;
    public Ball ball;
    public Text playerScoreText;
    public Text computerScoreText;

    public void PlayerScores()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();
        ball.ResetPosition();
    }

    public void ComputerScores()
    {
        computerScore++;
        computerScoreText.text = computerScore.ToString();
        ball.ResetPosition();
    }
}