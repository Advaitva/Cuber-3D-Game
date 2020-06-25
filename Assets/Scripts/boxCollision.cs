using UnityEngine;

public class boxCollision : MonoBehaviour
{
    public boxMove movement;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
