using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2_RotateWheels : MonoBehaviour
{
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("P2_Vertical");

        transform.Rotate(Vector3.right * Time.deltaTime * 360 * verticalInput);
    }
}
