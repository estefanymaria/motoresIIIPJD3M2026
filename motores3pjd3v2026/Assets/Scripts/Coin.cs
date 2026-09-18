using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        PlayerObserverManager.NotifyCoinCollected(other.transform.parent.gameObject);
        
        WinnerManager.Instance.CoinCollected();
        
        Destroy(gameObject);
    }
}