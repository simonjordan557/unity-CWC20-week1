using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 close = new Vector3(0, 4, -7);
    private Vector3 far = new Vector3(0, 5, -12);
    private Vector3 firstPerson = new Vector3(0, 2, 1);
    public Vector3 currentOffset;
    private Vector3 nextOffset;
    public KeyCode changeCamera;

    // Start is called before the first frame update
    void Start()
    {
        currentOffset = close;
        nextOffset = far;
    }

    // Update is called once per frame
    void Update()
    {
        // Offset camera behind player by adding to the player's position. Vector 3 is a class, so had to add a new instance to add 2 objects together
        if (Input.GetKeyDown(changeCamera))
        {
            currentOffset = nextOffset;

            if (nextOffset == close)
            {
                nextOffset = far;
            }

            else if (nextOffset == far)
            {
                nextOffset = firstPerson;
            }

            else if (nextOffset == firstPerson)
            {
                nextOffset = close;
            }
              
        }
       
        transform.position = player.transform.position + currentOffset;

        if (currentOffset == firstPerson)
        {
            transform.rotation = player.transform.rotation;
        }

        else transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
    }
}
