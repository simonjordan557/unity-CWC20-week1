using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private variables
    public float speed = 10.0f;
    private float turnSpeed = 40.0f;
    private float horizontalInput;
    private float verticalInput;
    public string verticalAxis;
    public string horizontalAxis;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Control vertical movement
        verticalInput = Input.GetAxis(verticalAxis);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // Control horizontal movement

        if (verticalInput != 0)
        {
            horizontalInput = Input.GetAxis(horizontalAxis);
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
        }

        
        

    

    }
}
