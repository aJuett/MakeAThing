using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate2 : MonoBehaviour
{
   public int speed;
   public float friction;
   public float lerpSpeed;
   public float zDeg;
    Quaternion fromRotation;
    Quaternion toRotation;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {

            zDeg -= Input.GetAxis("Mouse X") * speed * friction;
            fromRotation = transform.rotation;
            toRotation = Quaternion.Euler(0, 0, zDeg);
            transform.rotation = Quaternion.Lerp(fromRotation, toRotation, Time.deltaTime * lerpSpeed);
        }
    }
}