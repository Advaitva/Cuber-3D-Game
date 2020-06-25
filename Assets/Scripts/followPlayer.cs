using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    public UnityEngine.Vector3 cameraOffset;
    // Update is called once per frame
    void Update()
    {
        transform.position=player.position+cameraOffset;
    }
}
