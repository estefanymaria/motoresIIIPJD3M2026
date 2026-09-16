using UnityEngine;
using System;

public class PlayerObserverManager : MonoBehaviour
{
    public static Action<GameObject> OnCoinCollected;

    public static Action<int> OnCoinCountChanged;

    public static void NotifyCoinCollected(GameObject player)
    {
        OnCoinCollected?.Invoke(player);
    }

    public static void NotifyCoinCountChanged(int amount)
    {
        OnCoinCountChanged?.Invoke(amount);
    }
}