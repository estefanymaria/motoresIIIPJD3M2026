using StarterAssets;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        ThirdPersonController player =
            other.GetComponent<ThirdPersonController>();

        if (player != null)
        {
            player.CollectCoin();
        }

        Destroy(gameObject);
    }
}