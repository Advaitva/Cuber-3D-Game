using UnityEngine;
using UnityEngine.UI;

public class scores : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (player.position.z+65).ToString("0");
       
    }
}
