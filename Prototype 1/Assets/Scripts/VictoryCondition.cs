using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryCondition : MonoBehaviour
{
    public GameObject rival;
    private int fastRotation = 1080;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rival.transform.position.y < -3)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * fastRotation);
            transform.Translate(0.0f, (10.0f * Time.deltaTime), 0.0f);
        }
    }
}
