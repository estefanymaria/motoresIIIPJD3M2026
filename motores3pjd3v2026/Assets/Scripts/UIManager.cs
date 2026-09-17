using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI player1Score;
    public TextMeshProUGUI player2Score;
    
    private void OnEnable()
    {
        PlayerObserverManager.OnCoinCountChanged += UpdateScore;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnCoinCountChanged -= UpdateScore;
    }

    private void Start()
    {
        player1Score.text = "P1: 0";
        player2Score.text = "P2: 0";
    }
    
    private void UpdateScore(GameObject player, int score)
    {
        if (player.name.StartsWith("PlayerRobot (1)"))
        {
            player2Score.text = "P2: " + score;
        }
        else
        {
            player1Score.text = "P1: " + score;
        }
    }
}