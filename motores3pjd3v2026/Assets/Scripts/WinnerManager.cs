using TMPro;
using UnityEngine;
using StarterAssets;

public class WinnerManager : MonoBehaviour
{
    public static WinnerManager Instance;

    public GameObject winnerPanel;
    public TextMeshProUGUI winnerText;
    private int remainingCoins;

    private void Awake()
    {
        Instance = this;
    }
    
    private void Start()
    {
        remainingCoins = FindObjectsOfType<Coin>().Length;
    }
    
    public void CoinCollected()
    {
        remainingCoins--;

        Debug.Log("Restam " + remainingCoins + " estrelas.");

        if (remainingCoins <= 0)
        {
            ThirdPersonController[] players = FindObjectsOfType<ThirdPersonController>();

            int player1 = players[0].CoinCount;
            int player2 = players[1].CoinCount;

            if (player1 > player2)
            {
                ShowWinner("PLAYER 1 WINS!");
            }
            else if (player2 > player1)
            {
                ShowWinner("PLAYER 2 WINS!");
            }
            else
            {
                ShowWinner("DRAW!");
            }
        }
    }

    public void ShowWinner(string winner)
    {
        winnerPanel.SetActive(true);
        winnerText.text = winner;
        Time.timeScale = 0f;
    }
}