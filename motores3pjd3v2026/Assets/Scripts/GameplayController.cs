using UnityEngine;

public class GameplayController : MonoBehaviour
{
    private void Start()
    {
        GameManager.Instance.ChangeState(GameManager.GameState.Gameplay);
    }
}