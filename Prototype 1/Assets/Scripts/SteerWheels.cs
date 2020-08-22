using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteerWheels : MonoBehaviour
{
    private float horizontalInput;
    public string horizontalAxis;
    private float rateRotation;
    private float rateReturn;
    private float trackedRotation = 0.0f; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       
        horizontalInput = Input.GetAxis(horizontalAxis);

        rateRotation = Time.deltaTime * 90 * horizontalInput;

        rateReturn = Time.deltaTime * 360;

        trackedRotation += rateRotation;

        if (trackedRotation > 45)
        {
            trackedRotation = 45;
        }

        if (trackedRotation < -45)
        {
            trackedRotation = -45;
        }

        if ((trackedRotation < 45) && (trackedRotation > -45) && (horizontalInput != 0)) 
        {
            transform.Rotate(Vector3.up * rateRotation, Space.World);           
        }

        else if ((trackedRotation <= 45) && (trackedRotation >= -45) && (horizontalInput == 0))
        {
            if ((trackedRotation <= 45) && (trackedRotation >= 0))
            {
                transform.Rotate(Vector3.up * -1 * rateReturn, Space.World);
                trackedRotation -= rateReturn;
            }

            if ((trackedRotation >= -45) && (trackedRotation < 0))
            {
                transform.Rotate(Vector3.up * rateReturn, Space.World);
                trackedRotation += rateReturn;
            }
        }

    }
}
