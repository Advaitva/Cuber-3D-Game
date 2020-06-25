using UnityEngine;

public class endTrigger : MonoBehaviour
{
    public GameManager gameManager;
     void OnCollisionEnter()
    {
        gameManager.levelEnded();
    }
}
