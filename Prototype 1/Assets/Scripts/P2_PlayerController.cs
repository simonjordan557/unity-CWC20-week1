using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2_PlayerController : MonoBehaviour
{
    // Private variables
    public float speed = 10.0f;
    private float turnSpeed = 40.0f;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Control vertical movement
        verticalInput = Input.GetAxis("P2_Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // Control horizontal movement

        if (verticalInput != 0)
        {
            horizontalInput = Input.GetAxis("P2_Horizontal");
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
        }
    }
}
