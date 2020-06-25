using UnityEngine;

public class boxMove : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardUpdate=10000;
    public float sideForce = 200;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        rb.useGravity = true;
        rb.AddForce(0,0,10000);
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rb.position.y < 5)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        rb.AddForce(0,0,forwardUpdate*Time.deltaTime);
        if(Input.GetKey("d")){
            rb.AddForce(sideForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        else if(Input.GetKey("a")){
            rb.AddForce(-sideForce*Time.deltaTime,0,0, ForceMode.VelocityChange);
        }

    }
}
