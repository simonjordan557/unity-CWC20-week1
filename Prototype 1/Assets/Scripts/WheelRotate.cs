using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotate : MonoBehaviour
{
    private float verticalInput;
    public string verticalAxis;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis(verticalAxis);

        transform.Rotate(Vector3.right * Time.deltaTime * 360 * verticalInput);
    }
}
