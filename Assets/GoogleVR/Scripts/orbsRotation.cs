using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbsRotation : MonoBehaviour
{

    // Use this for initialization    
    public float speed = 30;
    public float xRange = 20;
    public float yRange = 4;
    Vector3 vector;


    void Update()
    {
        vector = new Vector3(Random.Range(-1 * xRange, xRange), Random.Range(-1 * yRange, yRange), 0f);
        transform.Rotate(vector * Time.deltaTime);
    }
}
