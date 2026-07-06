using UnityEngine;
using System;

public class PlayerObserverManager : MonoBehaviour
{
    public static Action<int> OnCoinCollected;

    public static void NotifyCoinCollected(int totalCoins)
    {
        OnCoinCollected?.Invoke(totalCoins);
    }
    
    
}