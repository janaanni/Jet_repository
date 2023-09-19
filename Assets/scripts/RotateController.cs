using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateController : MonoBehaviour
{
    public Vector3 rotateVector;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateVector *Time.deltaTime);
    }
}